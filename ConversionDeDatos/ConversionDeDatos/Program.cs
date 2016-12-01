using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = i;
            float f2 = 123.34f;
            float f3 = 122.1212f;
            int i3 = Convert.ToInt16(f3);
            int i2 = (int)f2;
            String number = "100";
            int numero = int.Parse(number);
            int result;

            String number2;
            Console.WriteLine("Ingresa un numero:");
            number2 = Console.ReadLine();

            bool conversion = int.TryParse(number2, out result);

            if (conversion)
            {
                Console.WriteLine("La conversion fue exitosa");
                Console.WriteLine("result = {0}", result);
            }
            else
            {
                Console.WriteLine("No se pudo llevar la consersion!!!");
            }

            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}
