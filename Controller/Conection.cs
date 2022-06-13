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

    }
}
