using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N1 = int.Parse(Console.ReadLine());
                int N2 = int.Parse(Console.ReadLine());

                int result = N1 / N2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divided by zero is not allowed");
            }
            catch(FormatException exception)
            {
                Console.WriteLine("Format error ! " + exception.Message);
            }
            Console.ReadLine();
        }
    }
}
