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
        public static void ShowResults(double input1, double input2, double sum, double diff, double mult, double div, double remain)
        {
            Console.WriteLine($"The result of {input1} + {input2} is {sum}");
            Console.WriteLine($"The difference of {input1} and {input2} is {diff}");
            Console.WriteLine($"The multiplication of {input1} and {input2} is {mult}");
            Console.WriteLine($"The division of {input1} and {input2} is {div}");
            Console.WriteLine($"The remainder of {input1} and {input2} is {remain}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("I AM GOING TO MATH YOU UP. GIVE ME A NUMBER!:");
            var input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("GIVE ME NUMBER 2!:");
            var input2 = double.Parse(Console.ReadLine());

            var sum = Sum(input1, input2);
            var diff = Difference(input1, input2);
            var mult = Multiplication(input1, input2);
            var div = Division(input1, input2);
            var remain = Remainder(input1, input2);

            ShowResults(input1, input2, sum, diff, mult, div, remain);
        }
    }
}
