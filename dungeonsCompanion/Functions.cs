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

        public static string LoadTextFile(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            //Reads the save.dat file in same directory as exe file and populates fields.
            string filename = "save.dat";
            var fullpath = Path.GetFullPath(filename);

            string[] lines = File.ReadAllLines(fullpath).Skip(1).Take(1).First().Split(',');

            foreach (string line in lines)
            {
                return line;
            }
            
        }
    }
}
