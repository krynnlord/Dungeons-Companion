using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dungeonsCompanionFunctions;
using dungeonsCompanion;

namespace Form1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutThisAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 aboutForm = new Form2();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void strBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void strComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
   

        }

        private void strComboBox_TextChanged(object sender, EventArgs e)
        {

            double modResult = Functions.CalcModStat(int.Parse(strComboBox.Text));
            strModBox.Text = modResult.ToString();

        }

        private void dexComboBox_TextChanged(object sender, EventArgs e)
        {
            double modResult = Functions.CalcModStat(int.Parse(dexComboBox.Text));
            dexModBox.Text = modResult.ToString();

        }

        private void constComboBox_TextChanged(object sender, EventArgs e)
        {
            double modResult = Functions.CalcModStat(int.Parse(constComboBox.Text));
            constModBox.Text = modResult.ToString();

        }

        private void intComboBox_TextChanged(object sender, EventArgs e)
        {
            double modResult = Functions.CalcModStat(int.Parse(intComboBox.Text));
            intModBox.Text = modResult.ToString();

        }

        private void wisComboBox_TextChanged(object sender, EventArgs e)
        {
            double modResult = Functions.CalcModStat(int.Parse(wisComboBox.Text));
            wisModBox.Text = modResult.ToString();

        }

        private void charComboBox_TextChanged(object sender, EventArgs e)
        {
            double modResult = Functions.CalcModStat(int.Parse(charComboBox.Text));
            charModBox.Text = modResult.ToString();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.SavetoTextFile(characterNameBox.Text, playernameTextbox.Text, classBox.Text, raceBox.Text, backgroundBox.Text, strComboBox.Text, dexComboBox.Text, constComboBox.Text, intComboBox.Text, wisComboBox.Text,charComboBox.Text);
            SaveDialog savecomplete = new SaveDialog();
            savecomplete.StartPosition = FormStartPosition.CenterParent;
            savecomplete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions.SavetoTextFile(characterNameBox.Text, playernameTextbox.Text, classBox.Text, raceBox.Text, backgroundBox.Text, strComboBox.Text, dexComboBox.Text, constComboBox.Text, intComboBox.Text, wisComboBox.Text, charComboBox.Text);

            //TestSQL
            Functions.SavetoDB(characterNameBox.Text, playernameTextbox.Text, classBox.Text, raceBox.Text, backgroundBox.Text, strComboBox.Text, dexComboBox.Text, constComboBox.Text, intComboBox.Text, wisComboBox.Text, charComboBox.Text);


            //Display Dialog that Save Completed Successfuly
            SaveDialog savecomplete = new SaveDialog();
            savecomplete.StartPosition = FormStartPosition.CenterParent;
            savecomplete.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] loadlines = { "xx" , "xx" , "xx" , "xx" , "xx" , "xx" , "xx" , "xx" , "xx" , "xx" , "xx"};


            loadlines = Functions.LoadTextFile(loadlines); 

            characterNameBox.Text = loadlines[0];
            playernameTextbox.Text = loadlines[1];
            classBox.Text = loadlines[2];
            raceBox.Text = loadlines[3];
            backgroundBox.Text = loadlines[4];
            strComboBox.Text = loadlines[5];
            dexComboBox.Text = loadlines[6];
            constComboBox.Text = loadlines[7];
            intComboBox.Text = loadlines[8];
            wisComboBox.Text = loadlines[9];
            charComboBox.Text = loadlines[10];

            //Display Dialog that Load Completed Successfuly
            LoadDialog loadcomplete = new LoadDialog();
            loadcomplete.StartPosition = FormStartPosition.CenterParent;
            loadcomplete.ShowDialog();
        }
    }
}
