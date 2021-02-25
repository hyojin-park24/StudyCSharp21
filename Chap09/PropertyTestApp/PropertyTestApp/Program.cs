using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Myclass
    {
        private int iValue; // 0~120℃ 값만 입력받는 멤버 변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        public int IValue 
        {
            get {
                return this.iValue;
            }
            set {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
                
            }
        }

        public Myclass(int iValue)
        {
            IValue = iValue;
            //this.SetValue (iValue);
        }

       /* public int GetValue()
        {
            return this.iValue;
        }

        public void SetValue(int iValue)
        {
            if (value < 0)
            {
                this.iValue = 0;
            }
            else if (iValue > 120)
            {
                this.iValue = 120;
            }
            else
            {
                this.iValue = iValue;
            }
        }*/

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(1200);
            myclass.PrintValue();

            //myclass.SetValue(108);
            myclass.IValue = 1200;
            myclass.PrintValue();
            //Console.WriteLine($"현재 온도는 {myclass.GetValue()}℃ 입니다.");
            Console.WriteLine($"현재 온도는 {myclass.IValue}℃ 입니다.");
        }
    }
}
