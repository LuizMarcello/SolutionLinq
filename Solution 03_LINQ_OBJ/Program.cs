using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> Lista = new List<Usuario>();
            Lista.Add(new Usuario() { Nome = "José", Email = "José@gmail.com" });
            Lista.Add(new Usuario() { Nome = "Luiz", Email = "luiz@hotmail.com" });
            Lista.Add(new Usuario() { Nome = "Carlos", Email = "carlos#gmail.com" });
            Lista.Add(new Usuario() { Nome = "Valeria", Email = "valeria@gmail.com" });
            Lista.Add(new Usuario() { Nome = "Gabriel", Email = "gabriel@hotmail.com" });

            //Retorna uma lista de usuários já filtrada, cfe. método "Contains()"
            var ListaFiltrada = Lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a => a);

            foreach (var item in ListaFiltrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadKey();
        }
    }
}
