// OPPGAVE 2
//Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”,
//enten en film eller en bok, dere velger.
//Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør, hvilke skuespillere som var med.
//Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.
using par_programmering_03;

class Program
{

    static Input InputBook = new Input();

    static void Main()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- FUCCING PIRATE BAY ---\n");
            Console.WriteLine("[1] Show movies\n[2] Add movies\n[Q] Quit");
            Console.Write("\nSelect: ");
            var input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "q":
                    Console.Clear();
                    return;
                case "1":
                    InputBook.DisplayFilm();
                    break;
                case "2":
                    Console.Clear();
                    InputBook.GetInput();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nIVALID INPUT (fuck you) :(");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
