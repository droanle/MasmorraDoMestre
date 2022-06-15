using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Controller
{
    public class Conection
    {
        private static string dataPath = Path.GetFullPath(@"..\..\Resources\Data");
        public SQLiteConnection con = new SQLiteConnection("Data Source= " + dataPath + @"\MasmoraDoMestreSGBD.sqlite");


        public Conection()
        {
            if (!File.Exists(dataPath + @"\MasmoraDoMestreSGBD.sqlite"))
            {
                // O banco de dados não foi criado
                CreateDb();
                CreateTable();
                InsertTestData();
            }
            else
            {
                // O banco de dados já foi criado
                try
                {
                    // A tabela já foi criada
                    SQLiteDataAdapter da = null;

                    conectar();
                    using (var cmd = con.CreateCommand())
                    {
                        foreach (string s in new String[]{ "Games", "Properties", "SecAttributes", "PropertiesValue", "SecAttributesValue", "Sheets" })
                        {
                            cmd.CommandText = "SELECT * FROM " + s;
                            da = new SQLiteDataAdapter(cmd.CommandText, con);
                        }
                    }
                    desconectar();

                } catch 
                {
                    // A tabela não foi criada
                    desconectar();
                    CreateTable();
                    InsertTestData();
                }
                
            }
        }

        // referencia https://www.macoratti.net/17/04/cshp_sqlite1.htm
        private void CreateDb()
        {
            try
            {
                SQLiteConnection.CreateFile(dataPath + @"\MasmoraDoMestreSGBD.sqlite");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ola ----- " + ex.Message);
                throw;
            }
        }

        private void CreateTable()
        {
            try
            {
                conectar();
                using (var cmd = con.CreateCommand())
                {
                    StreamReader fileReader = new StreamReader(dataPath + @"\comands_create_tables.sql");
                   
                    cmd.CommandText = fileReader.ReadToEnd();
                    cmd.ExecuteNonQuery();
                }
                desconectar();
            }
            catch (Exception ex)
            {
                desconectar();
                Console.WriteLine(ex.Message);
            }
        }

        private void InsertTestData()
        {
            try
            {
                conectar();
                using (var cmd = con.CreateCommand())
                {
                    StreamReader fileReader = new StreamReader(dataPath + @"\comands_insert_for_tests.sql");

                    cmd.CommandText = fileReader.ReadToEnd();
                    cmd.ExecuteNonQuery();
                }
                desconectar();
            }
            catch (Exception ex)
            {
                desconectar();
                Console.WriteLine(ex.Message);
            }
        }

        public void conectar()
        {
            con.Close();
            con.Open();
        }
        public void desconectar()
        {
            con.Close();
        }

        private DataTable querySelect(string sqlCommand)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                conectar();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = sqlCommand;
                    da = new SQLiteDataAdapter(cmd.CommandText, con);
                    da.Fill(dt);
                    desconectar();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DataTable getGame()
        {
            return querySelect("SELECT * FROM Games");
        }

        public DataTable getGame(int i)
        {
            return querySelect("SELECT * FROM Games WHERE Id=" + i);
        }

        public DataTable getSheet()
        {
            return querySelect("SELECT * FROM Sheets");
        }

        public DataTable getSheet(int i)
        {
            return querySelect("SELECT * FROM Sheets WHERE Source_Id=" + i);
        }

        public Boolean deleteSheet(int i)
        {
            try
            {
                conectar();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Sheets Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", i);
                    cmd.ExecuteNonQuery();
                }
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public DataRow getSheetTarget(int i)
        {
            return querySelect("SELECT * FROM Sheets WHERE Id=" + i).Rows[0];
        }

        public DataTable getAttributes(int i)
        {
            return querySelect("SELECT I.*, V.Value FROM SecAttributes I INNER JOIN SecAttributesValue V ON(I.Id = V.Id_Attributes) WHERE V.Owner_Id = " + i);         
        }

        public DataTable getProperties(int i, String Propertie_Type )
        {
            return querySelect("SELECT I.*, V.Value FROM Properties I INNER JOIN PropertiesValue V ON(I.Id = V.Id_Properties) WHERE V.Owner_Id = " + i + " AND I.Propertie_Type = '" + Propertie_Type + "'");
        }

        public String getProperties_List(int i)
        {
            return querySelect("SELECT Properties_List FROM Games WHERE Id=" + i).Rows[0]["Properties_List"].ToString();
        }

        public Boolean setPropertiesValue(int value, int OwnerId, String IdProperties)
        {
            try
            {
                using (var cmd = con.CreateCommand())
                {
                    conectar();
                    cmd.CommandText = "UPDATE PropertiesValue SET Value=@Value WHERE Owner_Id=@OwnerId AND Id_Properties=@IdProperties ;";
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@OwnerId", OwnerId);
                    cmd.Parameters.AddWithValue("@IdProperties", IdProperties);
                    cmd.ExecuteNonQuery();
                    desconectar();
                }

                return true;
            }
            catch (Exception ex) { desconectar(); return false; }
        }

        public Boolean setSecAttributesValue(string value, int OwnerId, string IdAttributes)
        {
            try
            {
                using (var cmd = con.CreateCommand())
                {
                    conectar();
                    cmd.CommandText = "UPDATE SecAttributesValue SET Value=@Value WHERE Owner_Id=@OwnerId AND Id_Attributes=@IdAttributes ;";
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@OwnerId", OwnerId);
                    cmd.Parameters.AddWithValue("@IdAttributes", IdAttributes);
                    cmd.ExecuteNonQuery();
                    desconectar();
                }

                return true;
            }
            catch (Exception ex) { desconectar(); return false; }
        }

        public Boolean setSheetsInfo(string value, int OwnerId, string column)
        {
            try
            {
                using (var cmd = con.CreateCommand())
                {
                    conectar();
                    cmd.CommandText = "UPDATE Sheets SET " + column + "=@Value WHERE Id = @OwnerId ;";
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@OwnerId", OwnerId);
                    cmd.ExecuteNonQuery();
                    desconectar();
                }

                return true;
            }
            catch (Exception ex) { desconectar(); return false; }
        }

        public Boolean createSheet(string name, string description, string type, int image, Boolean player, int IdGame)
        {
            SQLiteCommand cmd = con.CreateCommand();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            int IdSheets;
            try
            {

                conectar();

                cmd.CommandText = "INSERT INTO Sheets(Name, Description, Type, Image, Player, Source_Id) VALUES( @Name, @Description,  @Type,  @Image, @Player, @Source_Id );";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Image", image);
                cmd.Parameters.AddWithValue("@Player", player);
                cmd.Parameters.AddWithValue("@Source_Id", IdGame);
                cmd.ExecuteNonQuery();
                

                cmd.CommandText = "SELECT MAX(Id)  FROM Sheets";
                da = new SQLiteDataAdapter(cmd.CommandText, con);
                da.Fill(dt);

                Console.WriteLine(JsonConvert.SerializeObject(dt));

                IdSheets = int.Parse(dt.Rows[0]["MAX(Id)"].ToString());


                Console.WriteLine(JsonConvert.SerializeObject(IdSheets));

                da = null;
                dt = null;
                dt = new DataTable();

                cmd.CommandText = "SELECT Id FROM Properties WHERE Owner_Fk_Id=" + IdGame;
                da = new SQLiteDataAdapter(cmd.CommandText, con);
                da.Fill(dt);


                Console.WriteLine(JsonConvert.SerializeObject(dt));
                Console.WriteLine(dt.Rows.Count);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO PropertiesValue (Id_Properties, Value, Owner_Id) VALUES( '" + dt.Rows[i]["Id"] + "', '0', " + IdSheets + " ); ";
                    Console.WriteLine("INSERT INTO PropertiesValue (Id_Properties, Value, Owner_Id) VALUES( '" + dt.Rows[i]["Id"] + "', '0', " + IdSheets + " ); ");
                    cmd.ExecuteNonQuery();
                }

                da = null;
                dt = null;
                dt = new DataTable();

                cmd.CommandText = "SELECT Id FROM SecAttributes WHERE Owner_Fk_Id=" + IdGame;
                da = new SQLiteDataAdapter(cmd.CommandText, con);
                da.Fill(dt);

                Console.WriteLine(JsonConvert.SerializeObject(dt));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO SecAttributesValue (Id_Attributes, Value, Owner_Id) VALUES( '" + dt.Rows[i]["Id"] + "', '100/100', " + IdSheets + " ); ";

                    cmd.ExecuteNonQuery();
                }


                desconectar();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                desconectar(); return false; }              
            
        }

    }
}
