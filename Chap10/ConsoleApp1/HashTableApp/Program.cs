using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HachTable예제");

            Hashtable ht = new Hashtable();
            ht ["일"] = "One";
            ht ["이"] = "Two";
            ht ["삼"] = "Three";
            ht ["사"] = "Four";

            Console.WriteLine(ht["일"]);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            // 배열 초기화 하는 방법 
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);

            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789});

            ArrayList list3 = new ArrayList() { 123, 456, 789 };
            // 위와 같이 사용 가능!


        }
    }
}
