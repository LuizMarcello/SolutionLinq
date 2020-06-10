using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> ListaLivro = new List<Livro>();
            ListaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor Amado" });
            ListaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem Amado" });
            ListaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washington" });
            ListaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A vida na terra" });

            List<Autor> ListaAutor = new List<Autor>();
            ListaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            ListaAutor.Add(new Autor() { Id = 2, Nome = "Maria Maria" });
            ListaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

            var ListaJoin = from livros in ListaLivro join autor in ListaAutor on livros.AutorId equals autor.Id select new { livros, autor };

            foreach (var item in ListaJoin)
            {
                Console.WriteLine("Livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
            }
            Console.ReadKey();
        }
    }
}



