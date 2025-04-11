using System.Reflection.Metadata.Ecma335;

namespace General_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"RoundProperly(56.5): {RoundProperly(56.5)}");
            int rndmNum = 456;

            switch(rndmNum)
            {
                case int num1  when num1 < 457:
                    Console.WriteLine($"num1: {num1}");
                    Console.WriteLine("The number is less than 456");
                    break;
                case int num2 when num2 > 455:
                    Console.WriteLine($"num2: {num2}");
                    Console.WriteLine("The number is greater than 456");
                    break;
            }
        }
        private static double RoundProperly(double number)
        {
            double roundedNum = Math.Round(number);
            return roundedNum;
        }
    }
}
