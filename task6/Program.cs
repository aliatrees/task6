namespace task6
{
    internal class Program
    {
        
      public static bool lessThan100(int a, int b)
      {
            return (a + b) < 100;

      }     
        static void Main(string[] args)
        {
            Console.WriteLine(lessThan100(20, 30));
        }
    }
}
