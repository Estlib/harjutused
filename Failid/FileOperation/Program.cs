namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta siia oma postkasti aadress");

            string filePath = "G:\\Users\\K\\Desktop\\thing\\harjutused\\Failid\\FileOperation\\postkastiaadress.txt";
            string aadress = Console.ReadLine();

            File.WriteAllText(filePath, aadress);
        }
    }
}
