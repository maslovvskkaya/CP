using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CP
{
    public partial class Form3 : Form
    {
        string FormsLanguage;
        string RadioLanguage;
        Author agataChristie;
        Author simonBecket;
        Author stephenKing;
        Author arthurConanDoyle;
        Author craigJohnson;

        public Form3(string formsFormsLanguage)
        {
            InitializeComponent();
            FormsLanguage = formsFormsLanguage;
            RadioLanguage = formsFormsLanguage;
            button1.Text = FormsLanguage == "ENG" ? "Agata Christie" : "Агата Крісті";
            button2.Text = FormsLanguage == "ENG" ? "Simon Beckett" : "Саймон Бекетт";
            button3.Text = FormsLanguage == "ENG" ? "Stephen King" : "Стівен Кінг";
            button4.Text = FormsLanguage == "ENG" ? "Arthur Conan Doyle" : "Артур Конан Дойл";
            button5.Text = FormsLanguage == "ENG" ? "Craig Johnson" : "Крейг Джонсон";

            FormsLanguage = formsFormsLanguage;

            List<Book> agataChristieBooks = new List<Book>
            {
                new Book("The Mysterious Affair at Styles"),
                new Book("Murder on the Orient Express"),
                new Book("Death on the Nile"),
                new Book("A Murder Is Announced"),
            };
            agataChristie = new Author(
                "Agata Christie",
                "15.09.1890",
                "Torquay, Great Britain",
                agataChristieBooks,
                "Detective"
            );
            List<Book> simonBecketBooks = new List<Book>
            {
                new Book("Written in Bone"),
                new Book("Whispers of the Dead"),
                new Book("The Chemistry of Death"),
                new Book("Where There`s Smoke"),
                new Book("The Restless Dead"),
                new Book("The Calling of the Grave"),
            };
            simonBecket = new Author(
                "Simon Beckett",
                "20.04.1960",
                "Sheffield, England",
                simonBecketBooks,
                "Crime fiction"
            );
            List<Book> stephenKingBooks = new List<Book>
            {
                new Book("It, The Green Mile"),
                new Book("Fairy Tale"),
                new Book("Outsider"),
                new Book("Billy Summers"),
            };
            stephenKing = new Author(
                "Stephen Edwin King",
                "21.09.1947",
                "Portland, Maine, USA",
                stephenKingBooks,
                "Dark fantasy, science fiction, psychological suspense"
            );
            List<Book> arthurConanDoyleBooks = new List<Book>
            {
                new Book("The Hound of the Baskervilles"),
                new Book("The Lost World"),
                new Book("The Adventure of the Final Problem"),
                new Book("The Valley of Fear"),
            };
            arthurConanDoyle = new Author(
                "Arthur Conan Doyle",
                "22.05.1859",
                "Edinburgh, Scotland",
                arthurConanDoyleBooks,
                "History, fantasy, adventure, science-fiction, crimes, drama and oters"
            );
            List<Book> craigJohnsonBooks = new List<Book>
            {
                new Book("The Cold Dish"),
                new Book("Death Without Company"),
                new Book("As the Crow Files"),
                new Book("The Dark House, Hell is Empty"),
            };
            craigJohnson = new Author(
                "Craig Johnson Allen",
                "16.01.1961",
                "Huntington, West Virginia, USA",
                craigJohnsonBooks,
                "Mystery, thrillers"
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AgataCh = RadioLanguage == "ENG"
                ? $"FullName: {agataChristie.FullName}\nWas born: {agataChristie.Birthday}\nIn: {agataChristie.CityAndCountry}\nHer books: {String.Join(", ", agataChristie.Works.Select(b => b.Title))}\nGenre: {agataChristie.Genre}"
                : $"Повне ім'я: {agataChristie.FullName}\nНародилась: {agataChristie.Birthday}\nВ місті: {agataChristie.CityAndCountry}\nЇї книги: {String.Join(", ", agataChristie.Works.Select(b => b.Title))}\nЖанр: {agataChristie.Genre}";
            richTextBox1.Text = AgataCh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SimonB = RadioLanguage == "ENG"
                ? $"FullName: {simonBecket.FullName}\n Was born: {simonBecket.Birthday}\n In: {simonBecket.CityAndCountry}\n His books: {String.Join(", ", simonBecket.Works.Select(b => b.Title))}\n Genre: {simonBecket.Genre}"
                : $"Повне ім'я: {simonBecket.FullName}\n Народився: {simonBecket.Birthday}\n В місті: {simonBecket.CityAndCountry}\n Його книги: {String.Join(", ", simonBecket.Works.Select(b => b.Title))}\n Жанр: {simonBecket.Genre}";
            richTextBox1.Text = SimonB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StephenK = RadioLanguage == "ENG"
                ? $"FullName: {stephenKing.FullName}\n Was born: {stephenKing.Birthday}\n In: {stephenKing.CityAndCountry}\n His books: {String.Join(", ", stephenKing.Works.Select(b => b.Title))}\n Genre: {stephenKing.Genre}"
                : $"Повне ім'я: {stephenKing.FullName}\n Народився: {stephenKing.Birthday}\n В місті: {stephenKing.CityAndCountry}\n Його книги: {String.Join(", ", stephenKing.Works.Select(b => b.Title))}\n Жанр: {stephenKing.Genre}";
            richTextBox1.Text = StephenK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ArthurC = RadioLanguage == "ENG"
                ? $"FullName: {arthurConanDoyle.FullName}\n Was born: {arthurConanDoyle.Birthday}\n In: {arthurConanDoyle.CityAndCountry}\n His books: {String.Join(", ", arthurConanDoyle.Works.Select(b => b.Title))}\n Genre: {arthurConanDoyle.Genre}"
                : $"Повне ім'я: {arthurConanDoyle.FullName}\n Народився: {arthurConanDoyle.Birthday}\n В місті: {arthurConanDoyle.CityAndCountry}\n  Його книги: {String.Join(", ", arthurConanDoyle.Works.Select(b => b.Title))}\n Жанр: {arthurConanDoyle.Genre}";
            richTextBox1.Text = ArthurC;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string CraigJ = RadioLanguage == "ENG"
                ? $"FullName: {craigJohnson.FullName}\n Was born: {craigJohnson.Birthday}\n In: {craigJohnson.CityAndCountry}\n His books: {String.Join(", ", craigJohnson.Works.Select(b => b.Title))}\n Genre: {craigJohnson.Genre}"
                : $"Повне ім'я: {craigJohnson.FullName}\n Народився: {craigJohnson.Birthday}\n  В місті: {craigJohnson.CityAndCountry}\n Його книги: {String.Join(", ", craigJohnson.Works.Select(b => b.Title))}\n Жанр: {craigJohnson.Genre}";
            richTextBox1.Text = CraigJ;
        }

        public void changeRadioLanguage(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Name == "enRadio")
            {
                RadioLanguage = "ENG";
            }
            else
            {
                RadioLanguage = "UKR";
            }
        }
    }
}