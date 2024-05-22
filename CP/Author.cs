namespace CP
{
    public class Author
    {
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string CityAndCountry { get; set; }
        public string Works { get; set; }
        public string Genre { get; set; }

        public Author(string fullName, string birthday, string cityAndCountry, string works, string genre)
        {
            FullName = fullName;
            Birthday = birthday;
            CityAndCountry = cityAndCountry;
            Works = works;
            Genre = genre;
        }
    }
}