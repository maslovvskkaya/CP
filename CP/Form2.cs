using NPOI.SS.Formula;
using NPOI.SS.Formula.Functions;
using NPOI.XWPF.UserModel;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace CP
{
    public partial class Form2 : Form
    {
        string filepath;
        string Language;
        string filePath;

        public Form2(string language)
        {
            InitializeComponent();
            Language = language;
            button1.Text = Language == "ENG" ? "Search" : "Пошук";
            button2.Text = Language == "ENG" ? "Save for other quotes" : "Зберегти до інших цитат";
            button3.Text = Language == "ENG" ? "Save to own quotes" : "Зберегти до власних цитат";
            button4.Text = Language == "ENG" ? "Show quotes" : "Переглянути цитати";
            button5.Text = Language == "ENG" ? " Authors" : "Автори";
            button6.Text = Language == "ENG" ? "Books" : "Книги";
            filepath = "D:\\КН 1 курс\\АІП\\quotes.docx";
            filePath = "D:\\КН 1 курс\\АІП\\favoritequotes.docx";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var doc = new XWPFDocument(fs);
                foreach (var paragraph in doc.Paragraphs)
                {
                    if (paragraph.Text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        richTextBox1.Text = paragraph.Text;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(filepath))
            {
                string quote = textBox1.Text;
                using (var fs = new FileStream(filepath, FileMode.Append, FileAccess.Write))
                {
                    var doc = new XWPFDocument(fs);
                    var paragraph = doc.Paragraphs[doc.Paragraphs.Count - 1];
                    paragraph.CreateRun().SetText(quote);
                    doc.Write(fs);
                }
            }
            else
            {
                string textexeption = Language == "ENG" ? "Quote could not be saved" : "Цитату не вдалось зберегти";
                MessageBox.Show(textexeption);
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text2 = Language == "ENG" ? "Quote saved" : "Цитату збережено";
            string text21 = Language == "ENG" ? "Quote could not be saved" : "Цитату не вдалось зберегти";
            MessageBox.Show(text2);
            MessageBox.Show(text21);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* if (checkBox1.Checked)
             {
                 try
                 {
                     using (var doc = new XWPFDocument(File.OpenRead(filePath)))
                     {
                         textBox1.Clear();
                         foreach (var paragraph in doc.Paragraphs)
                         {
                             textBox1.AppendText(paragraph.Text + Environment.NewLine);
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Помилка при читанні файлу Word: " + ex.Message);
                 }

                  catch (Exception ex)
                  {
                      string text = Language == "ENG" ? "It was not possible to open the file with quotes.Try again" : "Не вдалось відкрити файл з цитатами. Спробуйте ще раз";
                      MessageBox.Show(text);

                  }
              }
        }
            else
            {
                if (System.IO.File.Exists(filePath))
                {
                    XWPFDocument document = null;
                    try
                    {
                        using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            document = new XWPFDocument(file);
                        }
                 //       richTextBox1.Text = document.Text.ToString();//
                    }
                    catch (Exception ex)
                    {
                        string text = Language == "ENG" ? "It was not possible to open the file with quotes.Try again" : "Не вдалось відкрити файл з цитатами. Спробуйте ще раз";
                        MessageBox.Show(text);

                    }
                }
            }
           
            /* using (var doc = new XWPFDocument(File.OpenRead(filepath)))
           {
               foreach (var paragraph in doc.Paragraphs)
               {
                   richTextBox1.Text = paragraph.Text;
               }
           }
            string text = Language == "ENG" ? "Quotes shown" : "Цитати показано"; */
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

