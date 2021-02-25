using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        //자식 클래스에서 재정의 할거야.
        public virtual void Initialize() //virtual이 있어야 override 활용 가능!!!! initialize : 초기화
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("리펄서 레이저장착!");
            Console.WriteLine("Micro-Rocket Launcher 장착!");
        }
    }

    class WarMarchine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket장착!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuit생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMarchine marchine = new WarMarchine();
            marchine.Initialize();

            Console.WriteLine("Ironman 생산");
            IronMan ironman = new IronMan();
            marchine.Initialize();
        }
    }
}
