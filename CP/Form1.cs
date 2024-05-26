using System;
using System.Windows.Forms;

namespace CP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => OpenForm2("ENG");

        private void button2_Click(object sender, EventArgs e) => OpenForm2("UA");

        private void OpenForm2(string language)
        {
            Form2 form2 = new Form2(language);
            form2.Show();
            this.Hide();
        }
    }
}
