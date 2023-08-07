namespace HelloWorldApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double Input_1 = 0, Input_2 = 0;
            checked
            {
                try
                {
                    do
                    {
                        Console.Write("Please Enter First Number : ");

                    } while (!double.TryParse(Console.ReadLine(), out Input_1));
                    do
                    {
                        Console.Write("Please Enter Second Number : ");

                    } while (!double.TryParse(Console.ReadLine(), out Input_2));

                    double Result = Sum(Input_1, Input_2);
                    Console.WriteLine($"The sum is : {Math.Round(Result, 4)}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static double Sum(double x, double y)
        {
            return x + y;
        }
    }
}