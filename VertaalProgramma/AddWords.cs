using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VertaalProgramma
{
    public partial class AddWords : Form
    {
        public AddWords()
        {
            InitializeComponent();
        }
        public string file = "";
        private void AddWords_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAdd;
            txtLanguage1.Focus();
            this.Text = "Add words " + Vlaggen.AddWordsLanguage;

        }
        private void taalBestandControle(string fileName)
        {
            file = @"C:\Temp\WordList\" + fileName + ".txt";
            string path = @"C:\Temp\WordList";
            
            try
            {
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                if (File.Exists(file) == false)
                {
                 //  File.Create(file);
                    var myFile = File.Create(file);
                    {
                        myFile.Close();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foutieve bestandsnaam. Pad \"" + file + "\" niet gevonden. " + Environment.NewLine + Environment.NewLine + ex.ToString());
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            taalBestandControle(Vlaggen.AddWordsLanguage);
            if (txtLanguage1.Text != "" && txtLanguage2.Text != "")
            { 
                string tekst = txtLanguage1.Text + "," + txtLanguage2.Text;
                StreamWriter sw = new StreamWriter(file,true);
                sw.WriteLine(tekst);
                sw.Close();
                txtLanguage1.Clear();
                txtLanguage2.Clear();
                txtLanguage1.Focus();
            }
            else
            { MessageBox.Show("Please fill in all fields."); txtLanguage1.Focus(); }
        }


    }
}



