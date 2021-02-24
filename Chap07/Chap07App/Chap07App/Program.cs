using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체사용");

            /*cat cat1 = new cat(); //고양이 객체의 실체(instance) 생성
            cat1.Name = "야옹이";
            cat1.Color = "흰색";
            cat1.Meow();

            cat kitty = new cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            cat nero = new cat();
            nero.Name = "검은 고양이 네로";
            nero.Color = "검은색";
            nero.Meow();*/

            cat yomi = new cat("요미", "흰색", "암컷");
            yomi.Meow();

        }
    }

    class cat //객체
    {
        public cat() { }

        public cat(string Name)
        {
            this.Name = Name; //this : 객체 자기 자신
        }

        public cat(string Name, string Color) : this(Name) //사용자 정의 생성자
        {
            this.Color = Color;
        }

        public cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        //속성, 특성, 변수
        public string Name; //이름
        public string Color; //색상
        public string Gender; //성별

        //행위, 기능, 메소드
        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상 {this.Color} / 성별 {this.Gender}) : 야옹!");
        }
    }

}
