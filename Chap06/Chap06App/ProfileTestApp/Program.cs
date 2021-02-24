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

            //[명명된 매개변수 - "",] 가독성에 짱 좋음!
            /*PrintProfile(phone:"010-1708-3826", name: "홍길동");
            PrintProfile(name:"홍길순", phone : "010-2708-3878" );*/
            
            //[선택적 매개변수 ] 순서중요! 뒤에서부터 값이 입력이 되어야만 가능
            PrintProfile("최백호");
        }
        public static int PrintProfile (string name, string phone = "010-8845-2413") // voide 쓸 때와 int 쓸 때와 다른 것을 인지해야 함
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
