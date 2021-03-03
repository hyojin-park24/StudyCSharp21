using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18App
{
    class StringApp
    {
        string temp2 = "Gloabal Variable String"; //var 사용 불가
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            // 기본 선언
            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1} 입니다.");
            string message2 = String.Empty; // = ("") 
            Console.WriteLine($"빈값 문자열 : {message2} 입니다.");
            string oldPath = "C:\\Program Files\\Bandizip"; //폴더, 파일 경로
            string newPath = @"C:\Program Files\Bandizip"; // 둘 다 같은거임

            String greeting = "Hello, World!";// string
            var temp1 = "Local Variable String"; //지역 변수에만 

            char[] letters = { 'H', 'e', 'l', 'l', 'o'};
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "Hello";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            string row = "Row1\r\nRow2\r\nRow3";
            Console.Write(row);

            Console.WriteLine("--");

            string row2 = "Row11\r\nRow22\r\nRow33";
            Console.Write(row2);

            string oldline = "Test" +
                "Test2" +
                "Test3";
            string multiline = @"New Test these are multilie end.";
            Console.WriteLine();
            Console.WriteLine(oldline);
            Console.WriteLine();
            Console.WriteLine(multiline);

            Console.WriteLine($"\u0001F47D"); //

            var book = (lastName : "박", firstName : "상현", 
                title : "이것이 C#이다", company : "한빛 미디어",
                releseDate : "2018-07-01", price : 30000,
                page : 812);

            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} )({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releseDate).ToString("yyyy년 MM월 dd일")}출간, 페이지 수 {book.page}, 금액 : {book.price: #,###}원");

            Console.WriteLine("문자열 조작(함수 사용)");
            string s5 = "Visual C# Express "; // 값이 총 19개
            Console.WriteLine(s5.Trim()); //스페이스(여백) 삭제
            var s6 = s5.Trim(); // 값이 총 17개로 바뀜 

            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7,2));

            Console.WriteLine(s6.Replace("C#", "Basic"));

            Console.WriteLine(s6.IndexOf("C"));
            Console.WriteLine(s6.Length);
            Console.WriteLine(s6.ToLower());
            Console.WriteLine(s6.ToUpper());

            //null

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(nullstr.Equals(emptystr)); //예외 발생

        }
    }
}
