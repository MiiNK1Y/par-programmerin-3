namespace par_programmering_03
{
    internal class Input
    {

        public string _title { get; private set; } = string.Empty;
        public string _about { get; private set; } = string.Empty;
        public string _director { get; private set; } = string.Empty;
        public int _year { get; private set; }

        public List<Film> films = new List<Film>();
        
        private void PushFilm()
        {
            Film NewFilm = new Film(_title, _about, _director, _year);
        }

        public void GetInput()
        {
            Console.Write("Title: ");
            _title = Console.ReadLine() ?? "";

            Console.Write("Year released: ");
            _year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Director: ");
            _director = Console.ReadLine() ?? "";

            Console.Write("About: ");
            _about = Console.ReadLine() ?? "";

            films.Add(new Film(_title, _about, _director, _year));
        }

        public void dispFilm() {
            foreach(Film x in films) {
                Console.WriteLine($"Title: {x._title}\nAbout: {x._about}\nDirector: {x._director}\nYear: {x._year}");
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
