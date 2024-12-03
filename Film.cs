namespace par_programmering_03
{
    internal class Film
    {
        public string _title { get; private set; } = string.Empty;
        public string _about { get; private set; } = string.Empty;
        public string _director { get; private set; } = string.Empty;
        public string _actors { get; private set; } = string.Empty;
        public int _year { get; private set; }

        public Film(string title, string about, string director, string actors, int year)
        {
            _title = title;
            _about = about;
            _director = director;
            _actors = actors;
            _year = year;
        }
    }
}
