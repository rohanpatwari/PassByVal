using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueApplication
{
    class Square
    {
        public void PerimeterSq(int a, int b)
        {
            a = 4 * a;
            b = 4 * b;
            Console.WriteLine(a + " " + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            Console.WriteLine(num1 + " " + num2);
            Square s = new Square();
            s.PerimeterSq(num1, num2);
            Console.WriteLine(num1 + " " + num2);
            Console.ReadKey();
        }
    }
}
