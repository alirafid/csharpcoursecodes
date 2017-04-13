using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_Literal_charctar
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 100;
            uint myuvar = 1000u;
            long mylvar = 10000l;
            ulong myulvar = 1000ul;


            float myflvar = 1.5f;

            double mydvar = 1000.55d;
            decimal mydecvar = 1000.5m;
            Console.WriteLine($"{mydvar}, {mydecvar}");

            Console.WriteLine("{0} {1} {2}", myVar , myuvar, mylvar );
            Console.ReadKey();
        } 
    }
}
