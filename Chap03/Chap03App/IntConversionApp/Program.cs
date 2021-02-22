﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int 값은 {inCastVal}");

            inCastVal += 5; // 32767 + 5 = 32772
            short shCastVal = (short) inCastVal;
            Console.WriteLine($"short값 변환한 int 값은 {shCastVal}"); //Overflow : 값이 넘쳐서 오류난 상태

            float flVal = 3.141592f; // f or F 써야함
            inCastVal = (int) flVal;
            Console.WriteLine($"float 값 변환한 int 값은 {inCastVal}");
            double dlVal = inCastVal; //3
            Console.WriteLine($"int값 변환한 double 값은 {dlVal}");

            object obj = 20; //Boxing
            int inUnboxingVal = (int)obj; // Unboxing

            string strVal = "200";
            int result = int.Parse (strVal) * 3; // 문자열을 숫자로 형변환 (글자는 안됌)
            Console.WriteLine($"200*3 = {result}");
        }
    }
}