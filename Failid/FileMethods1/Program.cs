namespace FileMethods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud
            keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu rida kasutajalt uuesti.
            Kui küsimine on lõppenud, küsitakse kasutajalt failinime, ja luuletus salvestatakse faili
            Pärast salvestust kuvatakse failisisu kasutajale tagasi
             
             */
            Console.WriteLine("Sisesta oma luuletus, salvesta see faili, ja vaata oma luuletus hiljem üle");
            int riduOlemas = 0;
            string olemasolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Luuletuse järgmise rea sisestuseks kirjuta midagi.");
                List<string> keelatudSõnad = new List<string>() { "fuck", "shit", "alkohoolik" };

                string hetkesisestus = "";
                while (hetkesisestus == "")
                {
                    hetkesisestus = ReadAnswer();
                    foreach (var ks in keelatudSõnad)
                    {
                        if (hetkesisestus.Contains(ks))
                        { 
                            hetkesisestus = "";
                            Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud.");
                        }
                    }
                }
                olemasolevSisu += "\n"+hetkesisestus;
                riduOlemas++;
            }
            Console.WriteLine("Sisesta failinimi, kuhu soovid oma luuletuse salvestada:");
            string failinimi = ReadAnswer();
            string filePath = "G:\\Users\\K\\Desktop\\thing\\harjutused\\Failid\\FileMethods1\\" + failinimi + ".txt";
            File.WriteAllText(filePath, olemasolevSisu);
            DisplayLuuletus(filePath);
        }

        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readLuuletus = new StreamReader(location)) 
            {
                while (readLuuletus.EndOfStream == false)
                {
                    Console.WriteLine(readLuuletus.ReadLine());
                }
                readLuuletus.Close();
            }
        }

        public static string ReadAnswer()
        {
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("Tee vastav sisestus: ");
                vastus = Console.ReadLine();
            }
            return vastus;
        }

    }
}
