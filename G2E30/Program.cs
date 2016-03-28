using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2E30
{
    class Program
    {
        /* 30. Elabore un programa que imprima el porcentaje de hombre y el porcentaje de mujeres que hay
               en un grupo de clases de IAI115. */

        static void Main(string[] args)
        {
            float m = 0, h = 0,t=0;
            float ph, pm, pt;
            Console.WriteLine("Ingrese la cantidad de hombres: ");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Muejeres");
            m = float.Parse(Console.ReadLine());
            t = h + m;
            pt = 100 / t;
            ph = pt * h;
            pm = pt * m;

            Console.WriteLine("El porcentaje de hombres es: {0} % \nEl porcentaje de Muejres es: {1} %", ph,pm);
            Console.ReadKey();
        }
    }
}
