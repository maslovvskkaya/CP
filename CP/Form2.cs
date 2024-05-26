using NPOI.XWPF.UserModel;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CP
{
    public partial class Form2 : Form
    {
        string quotesFilePath;
        string Language;
        string favQuotesFilePath;

        public Form2(string language)
        {
            InitializeComponent();
            Language = language;
            button1.Text = Language == "ENG" ? "Search" : "Пошук";
            button2.Text = Language == "ENG" ? "Save quote" : "Зберегти цитату";
            button3.Text = Language == "ENG" ? "Save favorite quote" : "Зберегти улюблену цитат";
            button4.Text = Language == "ENG" ? "Show quotes" : "Переглянути цитати";
            button5.Text = Language == "ENG" ? " Authors" : "Автори";
            button6.Text = Language == "ENG" ? "Books" : "Книги";
            quotesFilePath = Path.Combine(Application.StartupPath, "quotes.docx");
            favQuotesFilePath = Path.Combine(Application.StartupPath, "favorite_quotes.docx");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            if (textBox1.Text != String.Empty)
            {
                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    string[] paragraphs = SearchQuotesInFile(quotesFilePath, textBox1.Text);
                    richTextBox1.Text += string.Join(Environment.NewLine, paragraphs);
                }
                else if (checkBox2.Checked && !checkBox1.Checked)
                {
                    string[] paragraphs = SearchQuotesInFile(favQuotesFilePath, textBox1.Text);
                    richTextBox1.Text += string.Join(Environment.NewLine, paragraphs);
                }
                else
                {
                    string[] paragraphs = SearchQuotesInFile(quotesFilePath, textBox1.Text)
                        .Concat(SearchQuotesInFile(favQuotesFilePath, textBox1.Text)).ToArray();
                    richTextBox1.Text += string.Join(Environment.NewLine, paragraphs);
                }
            }
        }

        private string[] SearchQuotesInFile(string path, string searchTerm = "")
        {
            if (!File.Exists(path))
            {
                MessageBox.Show(Language == "ENG" ? "File not found" : "Файл не знайдено");
                return new string[0];
            }

            var paragraphsList = new System.Collections.Generic.List<string>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XWPFDocument doc = new XWPFDocument(fs);
                foreach (var paragraph in doc.Paragraphs)
                {
                    if (paragraph.Text.Contains(searchTerm))
                    {
                        paragraphsList.Add(paragraph.Text);
                    }
                }
            }

            return paragraphsList.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToFile(quotesFilePath, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteToFile(favQuotesFilePath, textBox1.Text);
        }

        private void WriteToFile(string path, string content)
        {
            if (content == String.Empty)
            {
                return;
            }

            XWPFDocument doc;
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    doc = new XWPFDocument(fs);
                }
            }
            else
            {
                doc = new XWPFDocument();
            }

            XWPFParagraph paragraph = doc.CreateParagraph();
            XWPFRun run = paragraph.CreateRun();
            run.SetText(content);
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                doc.Write(fs);
            }

            MessageBox.Show(Language == "ENG" ? "Quote saved" : "Цитату збережено");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (checkBox1.Checked)
            {
                richTextBox1.Text = string.Join(Environment.NewLine, SearchQuotesInFile(quotesFilePath));
                if (checkBox2.Checked)
                {
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += string.Join(Environment.NewLine, SearchQuotesInFile(favQuotesFilePath));
                }
            }
            else if (checkBox2.Checked)
            {
                richTextBox1.Text = string.Join(Environment.NewLine, SearchQuotesInFile(favQuotesFilePath));
            }
            else
            {
                richTextBox1.Text = string.Join(Environment.NewLine, SearchQuotesInFile(quotesFilePath));
                richTextBox1.Text += "\n";
                richTextBox1.Text += string.Join(Environment.NewLine, SearchQuotesInFile(favQuotesFilePath));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(Language);
            form3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(Language);
            form4.Show();
            this.Hide();
        }
    }
}