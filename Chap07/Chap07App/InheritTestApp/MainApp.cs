using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name; // 부모 클래스의 속성 

        public Parent(string Name)
        {
            this.Name = Name; //Name 초기화
            Console.WriteLine($"{this.Name}Parent() 생성자"); //this Name에 parent를 생성하겠음
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    // 자식클래스 만들게 (부모클래스 상속할거야)
    class Child : Parent
    {
        public String Color; //색상


        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

        public void Getcolor()
        {
            Console.WriteLine($"{this.Name}의 색상 {this.Color}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(" 부모 ");
            p.ParentMethod(); // 부모클래스 메서드 실행

            Child c = new Child("자식");
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식 클래스 메서드 실행
            c.Color = "황색";
            c.Getcolor();

        }
    }
}
