namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            string info = "";
            do
            {
                //kasutajalt info saamine
                Console.WriteLine("Palun sisesta filtreeritav lähteinfo: ");
                info = GetResponse();
                Console.WriteLine("Palun sisesta otsitav info: ");
                string searchThisWord = GetResponse();
                //filtreerimine ja teavitus
                bool doesWordExist = FindThisWord(searchThisWord, info);
                if (doesWordExist == true)
                {
                    Console.WriteLine("Leidsime sõna \"" + searchThisWord + "\" sinu sisestatud infost:");
                    Console.WriteLine(info);
                }
                else
                {
                    Console.WriteLine("Sõna \"" + searchThisWord + "\" infost puudub");
                }
                //programmi töö kordamine
                vastus = RepeatAction();
            } while (vastus == "jah");
            vastus = "";

            do
            {
                Console.WriteLine("Kas soovid infosse midagi juurde lisada?");
                vastus = GetResponse();
                if (vastus == "jah")
                {
                    Console.WriteLine("Kirjuta juurdelisatav info: ");
                    info += GetResponse();
                }
                vastus = "";
                Console.WriteLine("Kas tahad tegevust korrata? (jah/ei): ");
                vastus = GetResponse();

            } while (vastus == "jah");

            do
            {
                Console.WriteLine("Kas salvestad dokumendi töölauale, või dokumendikausta?");
                string kuhu = GetResponse();

                string saveFileHere = "";
                if (kuhu == "töölaud")
                {
                    saveFileHere = "G:\\Users\\K\\Desktop\\info.txt";
                    File.WriteAllText(saveFileHere, info);
                }
                else if(kuhu == "dokumendid")
                {
                    saveFileHere = "G:\\Users\\K\\Documents\\info.txt";
                    File.WriteAllText(saveFileHere, info);
                }
                else
                {
                    Console.WriteLine("ei saa aru,"+kuhu+" ei ole salvestatav asukoht");
                    vastus = RepeatAction();
                }
            } while (vastus == "jah");

            // programmi lõpp
            Console.WriteLine("Headaega");

        }

        private static string RepeatAction()
        {
            string vastus;
            Console.WriteLine("Kas tahad tegevust korrata? (jah/ei): ");
            vastus = GetResponse();
            return vastus;
        }

        public static bool FindThisWord(string filter, string toBeFiltered)
        {
            if (toBeFiltered.Contains(filter)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "") 
            { 
                sisestus = Console.ReadLine();
            }
            return sisestus;
        }
    }
}
