using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_charstringbool
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmain = char.MinValue;
                int charmax = char.MaxValue;

            char myvar = 'a';
            int myvarvalue = 'a';
            char myvarvalue2 = Convert.ToChar(myvarvalue);


          
                 Console.WriteLine("Min Char = {0} Max Char = {1} My Charctar = {2} My variable number = {3} my converison value = {4}", charmain, charmax, myvar, myvarvalue , myvarvalue2);
           
             string myString = (" this is my charctar a value 97 and this my charctar A value 75 ");
            Console.WriteLine("\nMy String = {0}", myString);


            bool myBool = true;
            Console.WriteLine("\n my boolean value is {0} ", myBool);
             Console.ReadKey();


        }
    }
}
