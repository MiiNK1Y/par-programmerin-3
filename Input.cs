namespace par_programmering_03
{
    internal class Input
    {

        public string _title { get; private set; } = string.Empty;
        public string _about { get; private set; } = string.Empty;
        public string _director { get; private set; } = string.Empty;
        public string _actors { get; private set; } = string.Empty;
        public int _year { get; private set; }

        private List<Film> _films = new List<Film>();


        private void DisplayRecentAdded()
        {
            var lastAddedFilm = _films.LastOrDefault();
            Console.Clear();
            Console.WriteLine("--- FUCCING PIRATE BAY ---\n");
            Console.WriteLine("------- LAST ADDED -------");

            Console.WriteLine(
                    $"Title: {lastAddedFilm._title}\n" +
                    $"Year: {lastAddedFilm._year}\n" +
                    $"Director: {lastAddedFilm._director}\n" +
                    $"Actors: {lastAddedFilm._actors}\n" +
                    $"About: {lastAddedFilm._about}");

            Console.WriteLine("------- LAST ADDED -------");
            Thread.Sleep(2000);
        }


        public void GetInput()
        {
            Console.WriteLine("--- FUCCING PIRATE BAY ---\n");
            Console.WriteLine("----- ADD YOUR MOVIE -----");
            Console.Write("Title: ");
            _title = Console.ReadLine() ?? "";

            Console.Write("Year released: ");
            _year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Director: ");
            _director = Console.ReadLine() ?? "";

            Console.Write("Actors (separate by comma): ");
            _actors = Console.ReadLine() ?? "";

            Console.Write("About: ");
            _about = Console.ReadLine() ?? "";

            _films.Add(new Film(_title, _about, _director, _actors, _year));
            DisplayRecentAdded();
        }


        public void DisplayFilm()
        {
            Console.Clear();
            Console.WriteLine("--- FUCCING PIRATE BAY ---\n");
            Console.WriteLine("---- YOUR ADDED MOVIES ---");

            foreach (Film x in _films)
            {
                Console.WriteLine(
                        "--------------------------\n" +
                        $"Title: {x._title}\n" +
                        $"About: {x._about}\n" +
                        $"Director: {x._director}\n" +
                        $"Actors: {x._actors}\n" +
                        $"Year: {x._year}\n" +
                        "--------------------------");
            }

            Console.Write("Press ENTER to go back to the menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
