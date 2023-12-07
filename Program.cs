using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Johan";
            byte Age = 40;
            bool IsPetOwner = true;
            double ShoeSize = 46.5;

            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My Age is " + Age);
            Console.WriteLine("Do I have a pet? " + IsPetOwner);
            Console.WriteLine("My shoe size is " + ShoeSize);
        }
    }
}
