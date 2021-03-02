using System;

namespace CallbackTestApp
{
    class Program
    {
        //오름차순 - a > b  1return OR 같으면 0 return OR a < b 이면 -1 return
        static int AscendCompare (int a, int b)
        {
            if (a > b) return 1; //a,b를 바꿀 것
            else if (a == b) return 0;
            else return -1;
        }
        //내름차순 - a < b 1return OR 같으면 0 return OR a > b 이면 -1 return
        static int DescendCompare (int a, int b)
        {
            if (a < b) return 1; //b,a 순서를 바꿀 것
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort ( int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - ( i + 1); j++)
                {
                    // 비교하여 값 위치 변경
                    if (comparer(DataSet[j], DataSet[j+1] > 0)
                    { 
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
