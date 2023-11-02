namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(2, 1);
            Console.WriteLine(answer);

            var answer2 = Methods.Add(2.0, 1.0);
            Console.WriteLine(answer2);

            var answer3 = Methods.Add(2.0m, 2.1m);
            Console.WriteLine(answer3);

            var answer4 = Methods.Add(2, 1, true);
            Console.WriteLine(answer4);
        }


    }

    internal class Methods
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)

            {

                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";

            }
        }
    }
}