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
using System.Drawing.Printing;

namespace VertaalProgramma
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Font printFont;
        private StreamReader streamToPrint;
        private StringBuilder sb;
        public List<string> alleWoordenLijsten = new List<string>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            alleWoordenLijsten.Clear();
            getWordListToolStripMenuItem.DropDownItems.Clear();
            deleteWordListToolStripMenuItem.DropDownItems.Clear();            
            fileToolStripMenuItem.DropDownItems.Clear();
            
            fileToolStripMenuItem.DropDownItems
                    .Add("Add list")
                    .Click += new System.EventHandler(addListToolStripMenuItem_Click);
            qAToolStripMenuItem.DropDownItems.Clear();
            multipleChoiceToolStripMenuItem.DropDownItems.Clear();



            getWordList();
            addGetList(getWordListToolStripMenuItem);
            addGetDeleteList(deleteWordListToolStripMenuItem);
            addWordsControl(fileToolStripMenuItem);
            QuestionList(qAToolStripMenuItem, multipleChoiceToolStripMenuItem);
        }

        private void inlezen(string fileName)
        {
            sb = new StringBuilder();
            string lijn;
            string[] velden = new string[1];

            try
            {

                StreamReader sr = new StreamReader(@"C:\Temp\WordList\" + fileName + ".txt");
                while (!sr.EndOfStream)
                {
                    lijn = sr.ReadLine();
                    velden = lijn.Split(',');
                    sb.AppendFormat("{0,-15} - {1}", velden[0], velden[1]).AppendLine();
                }
                txtList.Text = sb.ToString();
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fout");
            }

        }
        private void inlezenOmgekeerd(string fileName)
        {
            sb = new StringBuilder();
            string lijn;
            string[] velden = new string[1];

            try
            {

                StreamReader sr = new StreamReader(@"C:\Temp\WordList\" + fileName + ".txt");
                while (!sr.EndOfStream)
                {
                    lijn = sr.ReadLine();
                    velden = lijn.Split(',');
                    sb.AppendFormat("{0,-15} - {1}", velden[1], velden[0]).AppendLine();
                }
                txtList.Text = sb.ToString();
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fout");
            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var myFile = File.Create(@"C:\Temp\temp.txt");
            {
                myFile.Close();
            }

            StreamWriter sw = new StreamWriter(@"C:\Temp\temp.txt", true);
            sw.WriteLine(txtList.Text);
            sw.Close();

            try
            {
                streamToPrint = new StreamReader(@"C:\Temp\temp.txt");
                try
                {
                    printFont = new Font("Consolas", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                File.Delete(@"C:\Temp\temp.txt");
            }

        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file. 
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void QuestionList(ToolStripMenuItem ts, ToolStripMenuItem tm)
        {
            ts.DropDownItems.Clear();
            tm.DropDownItems.Clear();
            for (int i = 0; i < alleWoordenLijsten.Count; i++)
            {
                ts.DropDownItems
                    .Add(alleWoordenLijsten[i])
                    .Click += new System.EventHandler(qaQuestionList_Click);
                ts.DropDownItems
                   .Add(alleWoordenLijsten[i] + " Reversed")
                   .Click += new System.EventHandler(qaQuestionListReversed_Click);
                tm.DropDownItems
                    .Add(alleWoordenLijsten[i])
                    .Click += new System.EventHandler(multiQuestionList_Click);
                tm.DropDownItems
                   .Add(alleWoordenLijsten[i] + " Reversed")
                   .Click += new System.EventHandler(multiQuestionListReversed_Click);  
            }
        }
        private void multiQuestionListReversed_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text;
            Form frmMulti = new MultipleChoice();
            frmMulti.Show();
        }
        private void multiQuestionList_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text;
            Form frmMulti = new MultipleChoice();
            frmMulti.Show();
        }
        private void qaQuestionList_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text;
            Form frmQA = new QandA();
            frmQA.Show();
        }
        private void qaQuestionListReversed_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text;
            Form frmQA = new QandA();
            frmQA.Show();
        }
        private void addWordsControl(ToolStripMenuItem ts)
        {
            for (int i = 0; i < alleWoordenLijsten.Count; i++)
            {
                ts.DropDownItems
                    .Add("Add words " + alleWoordenLijsten[i])
                    .Click += new System.EventHandler(addwoordenlijst_Click);
            }
        }
        private void addGetList(ToolStripMenuItem ts)
        {
            for (int i = 0; i < alleWoordenLijsten.Count; i++)
            {
                ts.DropDownItems
                    .Add(alleWoordenLijsten[i])
                    .Click += new System.EventHandler(addGetList_Click);
                ts.DropDownItems
                    .Add(alleWoordenLijsten[i] + " Reversed")
                    .Click += new System.EventHandler(addGetListReverse_Click);
            }
        }
        private void addGetDeleteList(ToolStripMenuItem ts)
        {
            for (int i = 0; i < alleWoordenLijsten.Count; i++)
            {
                ts.DropDownItems
                    .Add(alleWoordenLijsten[i])
                    .Click += new System.EventHandler(addGetDeleteList_Click);
            }
        }
        private void addGetDeleteList_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                string path = @"C:\Temp\WordList\" + clickedItem + ".txt";
                File.Delete(path);
                frmMain_Load(sender, e);        
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Fout");
            }
        }
        private void addGetList_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text;
            txtList.Clear();
            inlezen(Vlaggen.AddWordsLanguage);
            btnPrint.Visible = true;
        }
        private void addGetListReverse_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text.Remove(clickedItem.Text.Length - 9);
            txtList.Clear();
            inlezenOmgekeerd(Vlaggen.AddWordsLanguage);
            btnPrint.Visible = true;
        }
        private void addwoordenlijst_Click(object sender, EventArgs e)
        {  
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            Vlaggen.AddWordsLanguage = clickedItem.Text.Substring(10);
            Form frmAddWords = new AddWords();
            frmAddWords.Show();
        }       
        private void getWordList()
        {
            string filePath = @"C:\Temp\WordList";
            if (Directory.Exists(filePath))
            {
                DirectoryInfo d = new DirectoryInfo(filePath);

                foreach (var f in d.GetFiles("*.txt"))
                {
                    alleWoordenLijsten.Add(f.Name.Substring(0, f.Name.Length - 4));

                }
            }
        }
        private void addListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lijstNaam = Microsoft.VisualBasic.Interaction.InputBox("What is the name of the list?");
            fileToolStripMenuItem.DropDownItems
                .Add("Add words " + lijstNaam)
                .Click += new System.EventHandler(addwoordenlijst_Click);
            addwoordenlijst_Click(new ToolStripMenuItem("Add words " + lijstNaam), e);

            getWordListToolStripMenuItem.DropDownItems
                .Add(lijstNaam)
                .Click += new System.EventHandler(addGetList_Click);

            getWordListToolStripMenuItem.DropDownItems
                .Add(lijstNaam + " Reversed")
                .Click += new System.EventHandler(addGetListReverse_Click);

            qAToolStripMenuItem.DropDownItems
                .Add(lijstNaam)
                .Click += new System.EventHandler(qaQuestionList_Click);
            qAToolStripMenuItem.DropDownItems
                   .Add(lijstNaam + " Reversed")
                   .Click += new System.EventHandler(qaQuestionListReversed_Click);
            multipleChoiceToolStripMenuItem.DropDownItems
                .Add(lijstNaam)
                .Click += new System.EventHandler(multiQuestionList_Click);
            multipleChoiceToolStripMenuItem.DropDownItems
               .Add(lijstNaam + " Reversed")
               .Click += new System.EventHandler(multiQuestionListReversed_Click);
            deleteWordListToolStripMenuItem.DropDownItems
                .Add(lijstNaam)
                .Click += new System.EventHandler(addGetDeleteList_Click);
        }
    }
}
