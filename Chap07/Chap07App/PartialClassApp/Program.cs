using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class Myclass
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }
    }
    partial class Myclass
    {
        static void Main(string[] args)
        {
            Myclass _class = new Myclass();
            _class.Method1();
            _class.Method2();
            _class.Method3();
            _class.Method4();
        }
    }
}
