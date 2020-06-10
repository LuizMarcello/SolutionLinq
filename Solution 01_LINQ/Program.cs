using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Há duas formas de trabalhar com o LINQ:(2 sintaxes)
            //1ª Sintaxe: Usando os métodos
            //2ª Sintaxe: Usando a forma literal

            //LINQ e Expressões LAMBDA
            //LAMBDA: Uma expressão usada no c# para que possa se usar parâmetros 
            //        e expressões em qualquer parte do código.
            //LAMBDA = (Entrada) => (expressao)
            //LINQ: Uma representação da linguagem SQL dentro do c#.
            //Ex usando métodos: Where, OrderBy, Select, ToList, etc...

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //Só os maiores que 10.
            //Colocando a lista em ordem crescente
            //1ª Sintaxe do LINQ(Usando os métodos):
            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            //2ª Sintaxe do LINQ(Usando a forma literal):
            //var listaFiltrada = from a in lista where a > 10 orderby a select a;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}



