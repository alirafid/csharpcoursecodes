using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_floatpointtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("min value = {0} max value = {1}", flmin, flmax);






         float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;







            Console.WriteLine("\n float value = {0}\n double value = {1}\n decimal value = {2}", flVar , dlVar , dcVar);

            Console.ReadKey();

        }
    }
}
