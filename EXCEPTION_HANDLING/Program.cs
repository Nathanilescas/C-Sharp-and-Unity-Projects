using System;


namespace EXCEPTION_HANDLING
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Pick a number to divide the array with.");
                int divideNum = Convert.ToInt32(Console.ReadLine());
                int[] numberList = { 12, 200, 100, 20, 30, 35};

                foreach(int num in numberList)
                {
                    Console.WriteLine(num / divideNum);
                }
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
