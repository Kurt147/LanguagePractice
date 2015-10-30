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
    public partial class MultipleChoice : Form
    {
        public MultipleChoice()
        {
            InitializeComponent();
        }
        private List<EngPol> woordenLijst = new List<EngPol>();
        private Random rndgetal = new Random();
        private Random rndMulti = new Random();
        private int randomGetal = 0, attemps = 0, correct = 0, skips = 0, randomMulti = 1, randomAnder1 = 0, randomAnder2 = 0;
        private int controleGetal = 0;
        private void MultipleChoice_Load(object sender, EventArgs e)
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
                if (woordenLijst.Count > 2)
                {
                    newWord();
                }
                else
                {
                    MessageBox.Show("Please add more words to this list");
                    this.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fout");
            }
        }
        private void newWord()
        {
            controleGetal = randomGetal;
            randomGetal = rndgetal.Next(woordenLijst.Count);
            if (randomGetal != controleGetal)
            {
                lblEnglish.Text = woordenLijst[randomGetal].EngPolEnglish;
                multi();
            }
            else
            {
                newWord();
            }
        }
        private void multi()
        {
            randomMulti = rndMulti.Next(1, 4);
            randomAnder1 = rndgetal.Next(woordenLijst.Count);
            randomAnder2 = rndgetal.Next(woordenLijst.Count);
            if (randomGetal == randomAnder1 || randomGetal == randomAnder2 || randomAnder1 == randomAnder2) { multi(); }
            if (randomMulti == 1) 
            { 
                rdb1.Text = woordenLijst[randomGetal].EngPolPolish;
                rdb2.Text = woordenLijst[randomAnder1].EngPolPolish;
                rdb3.Text = woordenLijst[randomAnder2].EngPolPolish;
            }
            else if (randomMulti == 2)
            {
                rdb2.Text = woordenLijst[randomGetal].EngPolPolish;
                rdb1.Text = woordenLijst[randomAnder1].EngPolPolish;
                rdb3.Text = woordenLijst[randomAnder2].EngPolPolish;
            }
            else if (randomMulti == 3)
            {
                rdb3.Text = woordenLijst[randomGetal].EngPolPolish;
                rdb2.Text = woordenLijst[randomAnder1].EngPolPolish;
                rdb1.Text = woordenLijst[randomAnder2].EngPolPolish;
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            skips++;
            newWord();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your score is " + correct.ToString() + "/" + attemps.ToString() + " and you skipped " + skips + " questions");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Answer = "";
            if(rdb1.Checked){Answer = rdb1.Text;}
            if(rdb2.Checked){Answer = rdb2.Text;}
            if (rdb3.Checked) { Answer = rdb3.Text; }

            if (Answer == woordenLijst[randomGetal].EngPolPolish)
            {
                MessageBox.Show("GOOD JOB!!!");
                newWord();
                attemps++;
                correct++;
            }
            else
            {
                MessageBox.Show("Wrong, try again");
                attemps++;
            }
        }
    }
}
