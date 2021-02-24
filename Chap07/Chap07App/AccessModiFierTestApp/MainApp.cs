using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModiFierTestApp

{   //접근 제한, 정보은닉 처리
    class Boiler
    {
        internal int temp = 5; //물 온도 //public>[protecte>private : 접근제한],internal (빈도 낮음)

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60) 
            {
                Console.WriteLine("물의 온도가 일정온도를 벗어났습니다.59℃ 맞춥니다.");
                this.temp = 59;
                return;
            } else
            {
                this.temp = temp; //온도 지정
            }
            
        }

        public int GetTemp(){
            return this.temp;
        }

        public void TurnOnBoiler() {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnOffBoiler() {
            Console.WriteLine("보일러를 끕니다."); 
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kiitturami = new Boiler();
            var currTemp = kiitturami.GetTemp ();
            Console.WriteLine($"현재온도는 {currTemp}℃ 입니다.");
            kiitturami.SetTemp(40);
            kiitturami.TurnOnBoiler();
            kiitturami.SetTemp(59);

            if (kiitturami.GetTemp() >= 59)
            {
                kiitturami.TurnOffBoiler();
            }
        }
    }
}
