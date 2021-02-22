using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 100.5f; //var는 지역 변수 선언 에서만 사용 가능, 밖에서 사용 부가능 float으로 밖에서 쓸 수 있음
            Console.WriteLine($"정수값은 {i}입니다.");
        }
    }
}
