using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversion implicita
            int i = 100;
            float f = i;
            Console.WriteLine(f);

            //conversion explicita
            float f2 = 123.43f;
            int i2 = (int)f2;
            Console.WriteLine(i2);

            Console.ReadKey();
        }
    }
}
