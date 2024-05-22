using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP
{
    public partial class Form3 : Form
    {
        string Language;
        AgataChristie agata;
        SimonBeckett simon;
        StephenKing stephen;
        ArthurConanDoyle arthur;
        CraigJohnson craig;

        public Form3(string language)
        {
            InitializeComponent();
            Language = language;
            button1.Text = Language == "ENG" ? "Agata Christie" : "Агата Крісті";
            button2.Text = Language == "ENG" ? "Simon Beckett" : "Саймон Бекетт";
            button3.Text = Language == "ENG" ? "Stephen King" : "Стівен Кінг";
            button4.Text = Language == "ENG" ? "Arthur Conan Doyle" : "Артур Конан Дойл";
            button5.Text = Language == "ENG" ? "Craig Johnson" : "Крейг Джонсон";
           
            Language = language;
            agata = new AgataChristie();
            SimonBeckett simon = new SimonBeckett();
            StephenKing stephen = new StephenKing();
            ArthurConanDoyle arthur = new ArthurConanDoyle();
            CraigJohnson craig = new CraigJohnson();
        }
        public class AgataChristie : Author
        {
            public AgataChristie()
            {
                    FullName = "Agata Christie";
                    Birthday = "15.09.1890";
                    CityandCountry = "Torquay, Great Britain";
                    Works = "The Mysterious Affair at Styles, Murder on the Orient Express, Death on the Nile, A Murder Is Announced";
                    Genre = "Detective"; }
            }
        }
        public class SimonBeckett : Author
        {
            public SimonBeckett()
            {
                FullName = "Simon Beckett";
                Birthday = "20.04.1960";
                CityandCountry = "Sheffield, England";
                Works = "Written in Bone, Whispers of the Dead, The Chemistry of Death, Where There`s Smoke, The Restless Dead, The Calling of the Grave";
                Genre = "Crime fiction";
            }
        }
        public class StephenKing : Author
        {
            public StephenKing()
            {
                var Stephen = new Author();
                FullName = "Stephen Edwin King";
                Birthday = "21.09.1947";
                CityandCountry = "Portland, Maine, USA";
                Works = "It, The Green Mile, Fairy Tale, Outsider, Billy Summers ";
                Genre = "Dark fantasy, science fiction, psychological suspense";
            }
        }
        public class ArthurConanDoyle : Author
        {
            public ArthurConanDoyle()
            {
                var Arthur = new Author();
                FullName = "Arthur Conan Doyle";
                Birthday = "22.05.1859";
                CityandCountry = "Edinburgh, Scotland";
                Works = "The Hound of the Baskervilles, The Lost World, The Adventure of the Final Problem, The Valley of Fear";
                Genre = "History, fantasy, adventure, science-fiction, crimes, drama and oters";
            }
        }
        public class CraigJohnson : Author
        {
            public CraigJohnson()
            {
                var Craig = new Author();
                FullName = "Craig Johnson Allen";
                Birthday = "16.01.1961";
                CityandCountry = "Huntington, West Virginia, USA";
                Works = "The Cold Dish, Death Without Company, As the Crow Files, The Dark House, Hell is Empty";
                Genre = "Mystery, thrillers";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string AgataCh = Language == "ENG" ? $"FullName: {agata.FullName}\nWas born: {agata.Birthday}\nIn: {agata.CityandCountry}\nHer books: {agata.Works}\nGenre: {agata.Genre}" :
            $"Повне ім'я: { agata.FullName}\nНародилась: { agata.Birthday}\nВ місті: { agata.CityandCountry}\nЇї книги: { agata.Works}\nЖанр: { agata.Genre}";
            richTextBox1.Text = AgataCh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SimonB = Language == "ENG" ? $"FullName: {simon.FullName}\n Was born: {simon.Birthday}\n In: {simon.CityandCountry}\n His books: {simon.Works}\n Genre: {simon.Genre}" :
            $"Повне ім'я: {simon.FullName}\n Народився: {simon.Birthday}\n В місті: {simon.CityandCountry}\n Його книги: {simon.Works}\n Жанр: {simon.Genre}";
            richTextBox1.Text = SimonB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StephenK = Language == "ENG" ? $"FullName: {stephen.FullName}\n Was born: {stephen.Birthday}\n In: {stephen.CityandCountry}\n His books: {stephen.Works}\n Genre: {stephen.Genre}" :
            $"Повне ім'я: {stephen.FullName}\n Народився: {stephen.Birthday}\n В місті: {stephen.CityandCountry}\n Його книги: {stephen.Works}\n Жанр: {stephen.Genre}";
            richTextBox1.Text = StephenK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ArthurC = Language == "ENG" ? $"FullName: {arthur.FullName}\n Was born: {arthur.Birthday}\n In: {arthur.CityandCountry}\n His books: {arthur.Works}\n Genre: {arthur.Genre}" :
            $"Повне ім'я: {arthur.FullName}\n Народився: {arthur.Birthday}\n В місті: {arthur.CityandCountry}\n  Його книги: {arthur.Works}\n Жанр: {arthur.Genre}";
            richTextBox1.Text = ArthurC;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string CraigJ = Language == "ENG" ? $"FullName: {craig.FullName}\n Was born: {craig.Birthday}\n In: {craig.CityandCountry}\n His books: {craig.Works}\n Genre: {craig.Genre}" :
            $"Повне ім'я: {craig.FullName}\n Народився: {craig.Birthday}\n  В місті: {craig.CityandCountry}\n Його книги: {craig.Works}\n Жанр: {craig.Genre}";
            richTextBox1.Text = CraigJ;
        }
    }
}
   

