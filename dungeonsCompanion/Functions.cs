using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form1;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using dungeonsCompanion;
using System.IO;
using System.Configuration;


namespace dungeonsCompanionFunctions
{
    public class Functions
    {

        public static double CalcModStat(double baseModStatValue)
        {
            //Calculates the Modifier Score from Base Stat Value
            double modStatValue = 0;
            modStatValue = (Math.Floor((baseModStatValue - 10) / 2));
            return modStatValue;
        }

        public static void SavetoTextFile(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            //Writes out to save.dat file in same directory as exe file
            string filename = "save.csv";
            var fullpath = Path.GetFullPath(filename);

            string[] saveDataHeaders = new string[] { "CharacterName,PlayerName,Class,Race,Background,STR,DEX,CONST,INT,WIS,CHAR" };
            System.IO.File.WriteAllLines(fullpath, saveDataHeaders);
            string[] saveDataText = new string[] { a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + i + "," + j + "," + k };
            System.IO.File.AppendAllLines(fullpath, saveDataText);

            MessageBox.Show("Export Complete");

        }

        public static void SavetoDB(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {

            //Writes to the Datase file

            SqlConnection connection;
            
            string connectionString = ConfigurationManager.ConnectionStrings["dungeonsDatabase"].ConnectionString;

            //Character Number. Static for now. Support for 5 characters in Future
            string charnum = "1";

            string query = "UPDATE Character SET CharacterName=@a,PlayerName=@b,Class=@c,Race=@d,Background=@e,STR=@f,DEX=@g,CONST=@h,INT=@i,WIS=@j,CHAR=@k WHERE Id=@Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
      
                    command.Parameters.AddWithValue("@a", a);
                    command.Parameters.AddWithValue("@b", b);
                    command.Parameters.AddWithValue("@c", c);
                    command.Parameters.AddWithValue("@d", d);
                    command.Parameters.AddWithValue("@e", e);
                    command.Parameters.AddWithValue("@f", f);
                    command.Parameters.AddWithValue("@g", g);
                    command.Parameters.AddWithValue("@h", h);
                    command.Parameters.AddWithValue("@i", i);
                    command.Parameters.AddWithValue("@j", j);
                    command.Parameters.AddWithValue("@k", k);
                    command.Parameters.AddWithValue("@Id", charnum);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Save Complete");
                    
            }
            
        }

        public static List<string> LoadfromDB(List<string> results)
        {
            //Reads from the Datase file

            SqlConnection connection;

            string connectionString = ConfigurationManager.ConnectionStrings["dungeonsDatabase"].ConnectionString;
                      
                       
            string query = "SELECT CharacterName,PlayerName,Class,Race,Background,STR,DEX,CONST,INT,WIS,CHAR FROM Character WHERE Id=1";

            using (connection = new SqlConnection(connectionString))
               
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Add(reader.GetString(i));
                        }
                    }

                }

                connection.Close();
                return results;        
            }


        }

        public static string[] LoadTextFile(string[] loadlines)
        {
            
            //Reads the save.dat file in same directory as exe file and populates fields.
            string filename = "save.csv";
            var fullpath = Path.GetFullPath(filename);

            try
            {
                string[] lines = File.ReadAllLines(fullpath).Skip(1).Take(1).First().Split(',');
                return lines;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
              
        }

       

    }
}
