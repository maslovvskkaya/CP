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

        private void button1_Click(object sender, EventArgs e) => ShowAuthorInfo(agataChristie);

        private void button2_Click(object sender, EventArgs e) => ShowAuthorInfo(simonBecket);

        private void button3_Click(object sender, EventArgs e) => ShowAuthorInfo(stephenKing);

        private void button4_Click(object sender, EventArgs e) => ShowAuthorInfo(arthurConanDoyle);

        private void button5_Click(object sender, EventArgs e)
        {
            ShowAuthorInfo(craigJohnson);
        }

        private void ShowAuthorInfo(Author author)
        {
            richTextBox1.Text = RadioLanguage == "ENG"
                ? $"FullName: {author.FullName}\n Was born: {author.Birthday}\n In: {author.CityAndCountry}\n His books: {String.Join(", ", author.Works.Select(b => b.Title))}\n Genre: {author.Genre}"
                : $"Повне ім'я: {author.FullName}\n Народився: {author.Birthday}\n  В місті: {author.CityAndCountry}\n Його книги: {String.Join(", ", author.Works.Select(b => b.Title))}\n Жанр: {author.Genre}";
        }

        public void ChangeRadioLanguage(object sender, EventArgs e)
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