using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456; // 지역 변수로 만듦 [숫자 : int]
            Console.WriteLine(123+p2); // 579 [int + int] = int
            Console.WriteLine("123" + p2); // [string + int] = string / 문자열이 하나라도 있으면 문자열 결합으로 바뀜
            Console.WriteLine($"123{p2}"); // [string] / 위와 결과값 같음 지금 방식이 훨씬 편함 (C# 6.0 이후 문자열 만드는 방법)
            Console.WriteLine("123" + "456"); //[string + string] / 123456 [문자 : string]

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine( a > b); //false (true,false 화면 출력시, 대문자로 바뀜)
            Console.WriteLine(a < b); // false
            Console.WriteLine( a >= b ); // true
            Console.WriteLine( a<=b ); //true
            Console.WriteLine( a == b ); //true
            Console.WriteLine(a != b); //false ( ! 는 '아니다'는 의미) 

            //논리 연산자
            Console.WriteLine("논리 연산자");
            Console.WriteLine( 10 > 9 && a > 0 );//true ('&&' 는 '그리고' 의미)
            Console.WriteLine( a > b || b > 0); // true ( || 는 '또는' 의미)
            Console.WriteLine(!(a < b)); //true

            // 조건연산자 단항 if 문을 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님"; // = > 조건 연산자 써볼게 

            /*string result;
            if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/

            Console.WriteLine(result);

            //병합연산자 (NULL 조건부 연산자)

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d}");

          
            

        }
    }
}
