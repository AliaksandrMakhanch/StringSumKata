using System;

namespace StringSumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSumUtility stringSumUtility = new StringSumUtility();

            string num1 = "123";
            string num2 = "456";

            string sum = stringSumUtility.Sum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
    }

    public class StringSumUtility
    {
        public string Sum(string num1, string num2)
        {
            int n1 = IsNaturalNumber(num1) ? int.Parse(num1) : 0;
            int n2 = IsNaturalNumber(num2) ? int.Parse(num2) : 0;
            int total = n1 + n2;
            return total.ToString();
        }

        private bool IsNaturalNumber(string number)
        {
            return int.TryParse(number, out int n) && n >= 0;
        }
    }
}