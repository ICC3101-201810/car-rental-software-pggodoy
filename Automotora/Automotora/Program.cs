using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto p1 = new Auto("p1");
            Auto p2 = new Auto("p2");
            Tractor t1 = new Tractor();
            Console.WriteLine("p1 {0} - p2 {1} - p3 {2}", p1.id.ToString(), p2.id.ToString(), t1.id.ToString());
            Console.Read();
        }
    }
}
