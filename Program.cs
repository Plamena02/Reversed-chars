using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Низове_и_знаци
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            var c = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}",c,b,a);
        }
    }
}
