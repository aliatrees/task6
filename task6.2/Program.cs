using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task6._2
{
    internal class Program
    {
        public static List<int> PrintArray(int number)
        {
            List<int> array = new List<int>();

            for (int counter = 1; counter <= number;)
            {
                array.Add(counter);
            }

            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", PrintArray(10)));
        }
    }
}
