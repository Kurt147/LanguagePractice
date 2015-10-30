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
    public partial class QandA : Form
    {
        public QandA()
        {
            InitializeComponent();
        }
        private List<EngPol> woordenLijst = new List<EngPol>();
        private Random rndgetal = new Random();
        private int randomGetal = 0, attemps = 0, correct = 0, skips = 0, cheated = 0;
        private void QandA_Load(object sender, EventArgs e)
        {
            string lijn;
            string[] velden = new string[1];
            string fileName;
            AcceptButton = btnCheck;
            
            try
            {

                if (Vlaggen.AddWordsLanguage.EndsWith("Reversed"))
                {
                    fileName = Vlaggen.AddWordsLanguage.Substring(0, Vlaggen.AddWordsLanguage.Length - 9);
                }
                else
                {
                    fileName = Vlaggen.AddWordsLanguage;
                }

                StreamReader sr = new StreamReader(@"C:\Temp\WordList\" + fileName + ".txt");
                while (!sr.EndOfStream)
                {
                    lijn = sr.ReadLine();
                    velden = lijn.Split(',');
                    EngPol engpol = new EngPol();
                    if (Vlaggen.AddWordsLanguage.EndsWith("Reversed"))
                    {
                        engpol.EngPolEnglish = velden[0];
                        engpol.EngPolPolish = velden[1];
                    }
                    else
                    {
                        engpol.EngPolEnglish = velden[1];
                        engpol.EngPolPolish = velden[0];
                    }
                    woordenLijst.Add(engpol);

                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fout");
            }
            if(woordenLijst.Count > 1)
            {
                newWord();
            }
            else
            {
                MessageBox.Show("Please add more words to this list");
                this.Close();
            }
            
        }

        private void newWord()
        {
            int controleGetal = randomGetal;
            randomGetal = rndgetal.Next(woordenLijst.Count);
            if(controleGetal != randomGetal)
            {
                lblEnglish.Text = woordenLijst[randomGetal].EngPolEnglish;
            }
            else
            {
                newWord();
            }
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            newWord();
            skips++;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Answer = txtPolish.Text;

            if (Answer == woordenLijst[randomGetal].EngPolPolish)
            {
                MessageBox.Show("GOOD JOB!!!");
                newWord();
                txtPolish.Clear();
                txtPolish.Focus();
                attemps++;
                correct++;
            }
            else
            {
                MessageBox.Show("Wrong, try again");
                attemps++;
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your score is " + correct.ToString() + "/" + attemps.ToString() + " and you skipped " + skips + " questions and you cheated " + cheated.ToString() + "times");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The correct answer is: " + woordenLijst[randomGetal].EngPolPolish);
            cheated++;
        }
    }
}
