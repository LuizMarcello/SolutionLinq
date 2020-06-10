using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //GROUP  -  DISTINCT
            //var listaFiltrada = listaNum.Distinct().OrderBy(a => a).Select(a => a);
            var listaFiltrada = listaNum.OrderBy(a => a).GroupBy(a => a).Select(a => a);
            //var listaFiltrada = listaNum.OrderBy(a => a).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item.Key);
            }
            Console.ReadKey();
        }
    }
}
