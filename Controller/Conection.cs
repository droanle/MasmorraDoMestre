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
        
        public DataTable getAll()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                conectar();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Games";
                    da = new SQLiteDataAdapter(cmd.CommandText, con);
                    da.Fill(dt);
                    desconectar();
                    return dt ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
