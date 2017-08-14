using System;

namespace math_operations
{
    class Program
    {
        public static double Sum(double x, double y) => x + y;
        public static double Difference(double x, double y) => x - y;
        public static double Multiplication(double x, double y) => x * y;
        public static double Division(double x, double y) => x / y;
        public static double Remainder(double x, double y) => x % y;
        public static void ShowResults(double operand1, double operand2, double sum, double diff, double mult, double div, double remain)
        {
            Console.WriteLine($"The result of {operand1} + {operand2} is {sum}");
            Console.WriteLine($"The difference of {operand1} and {operand2} is {diff}");
            Console.WriteLine($"The multiplication of {operand1} and {operand2} is {mult}");
            Console.WriteLine($"The division of {operand1} and {operand2} is {div}");
            Console.WriteLine($"The remainder of {operand1} and {operand2} is {remain}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("I AM GOING TO MATH YOU UP. GIVE ME A NUMBER!:");
            var operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("GIVE ME NUMBER 2!:");
            var operand2 = double.Parse(Console.ReadLine());

            var sum = Sum(operand1, operand2);
            var diff = Difference(operand1, operand2);
            var mult = Multiplication(operand1, operand2);
            var div = Division(operand1, operand2);
            var remain = Remainder(operand1, operand2);

            ShowResults(operand1, operand2, sum, diff, mult, div, remain);
        }
    }
}
