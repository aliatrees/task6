namespace task6._3
{
    internal class Program
    {

        public static int animals(int chickens, int cows, int pigs)
        {
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(animals(2,3,8));
        }
    }
}
