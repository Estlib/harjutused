using System.Data;
using System.Diagnostics;

namespace Meetod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm?");
            string lemmikFilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikFilm); //<--
            filmid = DoYouLikeThisMovie(filmid, "Tron 1983");
            /*kasuta meetodit siin*/
            List<string> otsitavadFilmid = new List<string> { "Terminator", "Vanamehe Film", "Kratt" };
            IdentifyMovies(filmid, otsitavadFilmid);
            //foreach (string item in filmid)
            //{
            //    Console.WriteLine(item);
            //}
            /*
             * kirjuta programm mis
             * küsib kasutajalt tema lemmikfilme, küsimine ise on meetodiga, meetodi tulemus tagastatakse muutujasse ✅
             * küsib kasutajalt peale seda tema lemmikfilmi, vastus hoitakse muutujas  ✅
             * programm kontrollib meetodiga, kas lemmikfilm asub kasutaja poolt sisestatud filmide hulgas ✅
             * kui ei ole, siis küsitakse, kus sinu lemmikfilm? ✅
             * kui on siis öeldakse Näe mäletasid ikka! ✅
             * programm küsib kasutajalt kas talle meeldib film X (programmeerija otsustab) ✅
             * Kui jah siis, lisatakse film järjendisse ✅
             * kui ei vingub programm vastu "aga see on ju hea film?" ✅
             ⚠tee kodus * on olemas kindlate filmide tuvastusmeetod, mis otsib, kas järjendis on "Terminator", "Vanamehe Film" või "Kratt"
             * Erinevate filmide kohta esitab meetod erineva sõnumi
             *Terminaatori kohta "Ill be back"
             *Vanamehe Filmi kohta "šnikurs"
             *Krati kohta "Vaata et ta sul tehisplära ajama ei hakka"
             */
        }

        /* kodutöö meetod siia */
        public static void IdentifyMovies(List<string> collection, List<string> filter)
        {
            //* Terminaatori kohta "Ill be back"
            //* Vanamehe Filmi kohta "šnikurs"
            //* Krati kohta "Vaata et ta sul tehisplära ajama ei hakka"
            string messages = "";
            foreach (var movie in collection)
            {
                int itemnr = 0;
                foreach (var filterItem in filter)
                {
                    if (itemnr == 0)
                    {
                        messages += "I'll be back.\n";
                    }
                    else if (itemnr == 1)
                    {
                        messages += "Šnikurs\n";
                    }
                    else if (itemnr == 2)
                    {
                        messages += "Vaata et ta sul tehisplära ajama ei hakka\n";
                    }
                    itemnr++;
                }
                itemnr = 0;
            }
            Console.WriteLine(messages);
        }

        public static List<string> DoYouLikeThisMovie(List<string> collection, string movieToAdd)
        {
            if (collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldib {movieToAdd}?");
                string vastus = ReadAnswer();

                if (vastus == "jah")
                {
                    collection.Add(movieToAdd);
                    Console.WriteLine("Lisasin filmi sulle");
                }
                else
                {
                    Console.WriteLine("Aga miks? See on ju hea film?");
                }
            }
            return collection;
        }

        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach (var item in collection)
            {
                if (item == findThis)
                {
                    itExists = true;
                }
            }
            if (itExists == true)
            {
                Console.WriteLine("Näe mäletasid ikka!");
            }
            else
            {
                Console.WriteLine("a kus sinu lemmikfilm?");
            }
        }

        public static string ReadAnswer()
        {
            string sisend = "";
            while (sisend == "")
            {
                sisend = Console.ReadLine();
            }
            return sisend;
        }

        public static List<string> GetMovies()
        {
            Console.WriteLine("Mis on su lemmikfilmid, sisesta ükshaaval, kui sisestada rohkem ei taha\n sisesta \"ei ole\"");
            string sisestus = "";
            List<string> siinOnFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.WriteLine("Järgmine film:");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    siinOnFilmid.Add(sisestus);
                }
            }
            return siinOnFilmid;
        }

    }
}
