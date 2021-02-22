using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season // 열거형 ( 하나의 타입으로 표현 )
        {
            Spring,
            Summer,
            Fall,
            Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값는 {PI}");
            // PI = 6.345;

            Season mySeason = Season.Summer;
            Console.WriteLine($"지금 계절은 핫 써머 아 핫핫 써머 일까요? {mySeason} 였습니다!");

            int a = 0; //null 허용 안됌
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");

        }
    }
}
