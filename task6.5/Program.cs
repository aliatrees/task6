namespace task6._5
{
    internal class Program
    {
        public static int FootballPoints(int wins, int draws, int losses)
        {
            return (wins * 3) + (draws * 1) + (losses * 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FootballPoints(3,4,2));
        }
    }
}
