namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Semaphore.Green);
        }

        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
