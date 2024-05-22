using System;
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
            agataChristie = new Author(
                "Agata Christie",
                "15.09.1890",
                "Torquay, Great Britain",
                "The Mysterious Affair at Styles, Murder on the Orient Express, Death on the Nile, A Murder Is Announced",
                "Detective"
            );
            simonBecket = new Author(
                "Simon Beckett",
                "20.04.1960",
                "Sheffield, England",
                "Written in Bone, Whispers of the Dead, The Chemistry of Death, Where There`s Smoke, The Restless Dead, The Calling of the Grave",
                "Crime fiction"
            );
            stephenKing = new Author(
                "Stephen Edwin King",
                "21.09.1947",
                "Portland, Maine, USA",
                "It, The Green Mile, Fairy Tale, Outsider, Billy Summers",
                "Dark fantasy, science fiction, psychological suspense"
            );
            arthurConanDoyle = new Author(
                "Arthur Conan Doyle",
                "22.05.1859",
                "Edinburgh, Scotland",
                "The Hound of the Baskervilles, The Lost World, The Adventure of the Final Problem, The Valley of Fear",
                "History, fantasy, adventure, science-fiction, crimes, drama and oters"
            );
            craigJohnson = new Author(
                "Craig Johnson Allen",
                "16.01.1961",
                "Huntington, West Virginia, USA",
                "The Cold Dish, Death Without Company, As the Crow Files, The Dark House, Hell is Empty",
                "Mystery, thrillers"
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AgataCh = RadioLanguage == "ENG"
                ? $"FullName: {agataChristie.FullName}\nWas born: {agataChristie.Birthday}\nIn: {agataChristie.CityAndCountry}\nHer books: {agataChristie.Works}\nGenre: {agataChristie.Genre}"
                : $"Повне ім'я: {agataChristie.FullName}\nНародилась: {agataChristie.Birthday}\nВ місті: {agataChristie.CityAndCountry}\nЇї книги: {agataChristie.Works}\nЖанр: {agataChristie.Genre}";
            richTextBox1.Text = AgataCh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SimonB = RadioLanguage == "ENG"
                ? $"FullName: {simonBecket.FullName}\n Was born: {simonBecket.Birthday}\n In: {simonBecket.CityAndCountry}\n His books: {simonBecket.Works}\n Genre: {simonBecket.Genre}"
                : $"Повне ім'я: {simonBecket.FullName}\n Народився: {simonBecket.Birthday}\n В місті: {simonBecket.CityAndCountry}\n Його книги: {simonBecket.Works}\n Жанр: {simonBecket.Genre}";
            richTextBox1.Text = SimonB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StephenK = RadioLanguage == "ENG"
                ? $"FullName: {stephenKing.FullName}\n Was born: {stephenKing.Birthday}\n In: {stephenKing.CityAndCountry}\n His books: {stephenKing.Works}\n Genre: {stephenKing.Genre}"
                : $"Повне ім'я: {stephenKing.FullName}\n Народився: {stephenKing.Birthday}\n В місті: {stephenKing.CityAndCountry}\n Його книги: {stephenKing.Works}\n Жанр: {stephenKing.Genre}";
            richTextBox1.Text = StephenK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ArthurC = RadioLanguage == "ENG"
                ? $"FullName: {arthurConanDoyle.FullName}\n Was born: {arthurConanDoyle.Birthday}\n In: {arthurConanDoyle.CityAndCountry}\n His books: {arthurConanDoyle.Works}\n Genre: {arthurConanDoyle.Genre}"
                : $"Повне ім'я: {arthurConanDoyle.FullName}\n Народився: {arthurConanDoyle.Birthday}\n В місті: {arthurConanDoyle.CityAndCountry}\n  Його книги: {arthurConanDoyle.Works}\n Жанр: {arthurConanDoyle.Genre}";
            richTextBox1.Text = ArthurC;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string CraigJ = RadioLanguage == "ENG"
                ? $"FullName: {craigJohnson.FullName}\n Was born: {craigJohnson.Birthday}\n In: {craigJohnson.CityAndCountry}\n His books: {craigJohnson.Works}\n Genre: {craigJohnson.Genre}"
                : $"Повне ім'я: {craigJohnson.FullName}\n Народився: {craigJohnson.Birthday}\n  В місті: {craigJohnson.CityAndCountry}\n Його книги: {craigJohnson.Works}\n Жанр: {craigJohnson.Genre}";
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