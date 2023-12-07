namespace Mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Semaphore.Green);
        }

        enum Semaphore : byte
        {
            Red,
            Yellow,
            Green
        }
    }
}
