using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventApp
{
    delegate void EventHandler(string message); //메시지 받아서 처리하는 대리자 선언 
    class CustomNotifier
    {//이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened;

        public void Dosomething (int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened($"{number} : 짝 !");
            }
        }
    }
    class Program
    {
        //이벤트가 발생했을 때 실행되는 메서드 (이벤트 핸들러)
        public static void MyHandler (string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i <= 100; i++)
            {
                notifier.Dosomething(i);
            }
        }
    }
}
