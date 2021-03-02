using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속...");
            int x = 108, y = 0;
            int result = 0;

            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            Console.WriteLine(" 또 나머지 일처리 계속...");
        }
    }
}
