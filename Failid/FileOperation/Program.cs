
namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kirjuta siia oma postkasti aadress");

            //string filePath = "G:\\Users\\K\\Desktop\\thing\\harjutused\\Failid\\FileOperation\\postkastiaadress.txt";
            //string aadress = Console.ReadLine();

            //File.WriteAllText(filePath, aadress);

            Console.WriteLine("Kõik laulusõnad");

            DisplayThisFile();
        }

        private static void DisplayThisFile()
        {
            string line = "";
            try
            {
                using (
                    StreamReader readThisThing = new StreamReader
                    ("G:\\Users\\K\\Desktop\\thing\\harjutused\\Failid\\FileOperation\\mjbj.txt") )
                {
                    int lineCount = 0;
                    while (readThisThing.EndOfStream == false)
                    {
                        lineCount++;
                        line = readThisThing.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(lineCount+" "+line+" . Reapikkus on"+pikkus);
                    }
                    readThisThing.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest:"+e.Message);
                throw;
            }
        }
    }
}
