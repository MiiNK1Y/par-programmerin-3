namespace par_programmering_03
{
    internal class Input
    {

        public string _title { get; private set; } = string.Empty;
        public string _about { get; private set; } = string.Empty;
        public string _director { get; private set; } = string.Empty;
        public int _year { get; private set; }

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
        }
    }
}
