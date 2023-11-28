// See https://aka.ms/new-console-template for more information
namespace GetSeconds;
class Program
{
    static void Main(string[] args)
    {

        int input;
        int sek;
        int min;
        int hour;
        int day;
        int year;
        string ent;

        Console.WriteLine("Wollen Sie ihre Zeiten umrechnen? : ");
        ent = Console.ReadLine();

        if (ent == "yes")
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Geben Sie ihre Zeit an (s) : ");
                input = Convert.ToInt32(Console.ReadLine());

                sek = input / 10;
                min = sek / 60;
                sek = sek % 60;

                hour = min / 60;
                min = min % 60;

                day = hour / 24;
                hour = hour % 24;

                year = day / 365;
                day = day % 365;

                Console.WriteLine("Ihre umgerechnete Angabe : " + year + " Jahr(e) " + day + " Tag(e) " + hour + " Stunde(n) " + min + " Minute(n) " + sek + " Sekunde(n) ");
            }
        }
        else  Console.WriteLine("Biite valide Eingabe benutzen!");

    }
}


        
