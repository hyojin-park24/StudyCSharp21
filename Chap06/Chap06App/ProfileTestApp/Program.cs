using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("박효진", "010-8845-2413");

           if( PrintProfile(null, "010-1111-2222") == -1);
            {
                Console.WriteLine("프로필 출력 시 오류가 발생했습니다.");
            }
        }
        public static int PrintProfile (string name, string phone) // voide 쓸 때와 int 쓸 때와 다른 것을 인지해야 함
        {    if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }

            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰 번호 : {phone}");
            return 0;
        }
    }
}
