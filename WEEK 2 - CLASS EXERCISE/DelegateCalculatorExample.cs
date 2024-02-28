namespace WEEK_2___CLASS_EXERCISE
{
    internal class DelegateCalculatorExample
    {
        static void Main(string[] args)
        {
            Func<int, int, double> addition = (a, b) => a + b;
            Func<int, int, double> subtractition = (a, b) => a - b;
            Func<int, int, double> multiplication = (a, b) => a * b;
            Func<int, int, double> division = (a, b) =>
            {
                if (b == 0)
                {
                    return double.NaN;
                }

                return a / b;
            };
            
            
        }
        //static void AddNumbers(Func<int, int, double> sum)
        //{
        //    int x = 6;
        //    int y = 7;
        //    double result = sum(x, y);

        //    Console.WriteLine("Result of addition" + result);
        //}

    }
}
