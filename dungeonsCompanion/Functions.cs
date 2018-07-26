using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using dungeonsCompanion;

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
            //Writes out to save.dat file. Temporary data dump for now
            string[] saveDataHeaders = new string[] { "CharacterName,PlayerName,Class,Race,Background,STR,DEX,CONST,INT,WIS,CHAR" };
            System.IO.File.WriteAllLines(@"D:\Datadump\data.sav", saveDataHeaders);
            string[] saveDataText = new string[] { a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + i + "," + j + "," + k };
            System.IO.File.AppendAllLines(@"D:\Datadump\data.sav", saveDataText);
        }

        public static void SaveToDatabase(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {

            SqlConnection con = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dungeonsDatabase"));
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CharacterStats(CharacterName,PlayerName,Class,Race,Background,STR,DEX,CONST,INT,WIS,CHAR) values (a,b,c,d,e,f,g,h,i,j,k)",con);
            con.Close();
             
        }
    }
}
