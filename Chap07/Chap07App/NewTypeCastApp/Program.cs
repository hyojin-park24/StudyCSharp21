using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal //포유류
    {
        public string Name { get; set; }
        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을(를) 키우다");
        }
    }

    class Dog : Mammal //강아지
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal //고양이
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹~!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog ppopi = new Dog();
            ppopi.Name = "뽀삐";
            ppopi.Nurse();
            ppopi.Bark();

            /*Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();*/

            if (ppopi is Mammal) // 과연 뽀삐는 포유류인가?
            {
                //일반적인 값형식 변환 : long = int값
                Mammal mammal1 = ppopi as Mammal;
                //참조 형식은 as로 형변환 하기 때문 [생략 가능!]
                mammal1.Nurse();

            }

            if (mammal is Dog)
            {
                ppopi = mammal as Dog;
                ppopi.Nurse();
                ppopi.Bark();
            }
        }
    }
}
