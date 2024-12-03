// OPPGAVE 2
//Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”,
//enten en film eller en bok, dere velger.
//Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør, hvilke skuespillere som var med.
//Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.
using par_programmering_03;

class Program
{


    static Input InputBook = new Input();
    // fill in the fields
    // InputBook.GetInput();

    // InputBook.dispFilm();


    static void Main()
    {

        while (true)
        {
            
            Console.WriteLine("[1] Show movies\n[2] Add movies\n[Q] quit");
            Console.Write("\nPress the number asosiated with you option:");
            var input = Console.ReadLine();

            switch (input)
            {
                case "q":
                    break;
                case "1":
                    InputBook.dispFilm();
                    break;
                case "2":
                    InputBook.GetInput();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("IVALID INPUT :(");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}


