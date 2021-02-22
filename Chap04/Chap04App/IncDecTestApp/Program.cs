using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");

            Console.WriteLine($"현재 숫자는 {result++}");
            // ++result 와 result++ 랑 값변환 다름으로 위치 중요 (전치증감 / 후치증감)
            // ++result 는 + 먼저, result++ 는 값 먼저 주고 +를 뒷 작업으로 보냄
            Console.WriteLine($"전치감소 숫자는 {--result}");
            Console.WriteLine($"후치감소 숫자는 {result--}");
        }
    }
}
