namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birthdate: ");
            var birthdate = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and age is {age}.\nYour birthdate is {birthdate}");
            Console.ReadKey();
        }
    }
}
