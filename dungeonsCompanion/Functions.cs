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
            string filename = "save.dat";
            var fullpath = Path.GetFullPath(filename);

            string[] saveDataHeaders = new string[] { "CharacterName,PlayerName,Class,Race,Background,STR,DEX,CONST,INT,WIS,CHAR" };
            System.IO.File.WriteAllLines(fullpath, saveDataHeaders);
            string[] saveDataText = new string[] { a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + i + "," + j + "," + k };
            System.IO.File.AppendAllLines(fullpath, saveDataText);
        }

        public static void SavetoDB(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {


            //Writes to the Datase file

            SqlConnection connection;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CharacterDB"].ConnectionString;
            int charnum = 1;
            string query = "UPDATE Characters SET CharacterName = @a,PlayerName = @b,Class = @c,Race = @d,Background = @e,STR = @f,DEX = @g,CONST = @h,INT = @i,WIS = @j,CHAR = @k WHERE Id = @Id";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                //command.Parameters.AddWithValue("@Id", charnum);
                //command.Parameters.AddWithValue("@a", a);
                //command.Parameters.AddWithValue("@b", b);
                //command.Parameters.AddWithValue("@c", c);
                //command.Parameters.AddWithValue("@d", d);
                //command.Parameters.AddWithValue("@e", e);
                //command.Parameters.AddWithValue("@f", f);
                //command.Parameters.AddWithValue("@g", g);
                //command.Parameters.AddWithValue("@h", h);
                //command.Parameters.AddWithValue("@i", i);
                //command.Parameters.AddWithValue("@j", j);
                //command.Parameters.AddWithValue("@k", k);

                command.Parameters.Add("@Id", SqlDbType.Int).Value = charnum;
                command.Parameters.Add("@a", SqlDbType.NVarChar).Value = a;
                command.Parameters.Add("@b", SqlDbType.NVarChar).Value = b;
                command.Parameters.Add("@c", SqlDbType.NVarChar).Value = c;
                command.Parameters.Add("@d", SqlDbType.NVarChar).Value = d;
                command.Parameters.Add("@e", SqlDbType.NVarChar).Value = e;
                command.Parameters.Add("@f", SqlDbType.NVarChar).Value = f;
                command.Parameters.Add("@g", SqlDbType.NVarChar).Value = g;
                command.Parameters.Add("@h", SqlDbType.NVarChar).Value = h;
                command.Parameters.Add("@i", SqlDbType.NVarChar).Value = i;
                command.Parameters.Add("@j", SqlDbType.NVarChar).Value = j;
                command.Parameters.Add("@k", SqlDbType.NVarChar).Value = k;

                connection.Open();
                command.ExecuteNonQuery();

            }

        }







        public static string[] LoadTextFile(string[] loadlines)
        {
            
            //Reads the save.dat file in same directory as exe file and populates fields.
            string filename = "save.dat";
            var fullpath = Path.GetFullPath(filename);

            string[] lines = File.ReadAllLines(fullpath).Skip(1).Take(1).First().Split(',');
            return lines;
              
        }
    }
}
