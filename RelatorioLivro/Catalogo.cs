using System;
using System.Collections.Generic;

namespace RelatorioLivro
{
    public class Catalogo : ICatalogo
    {
        //Método recebendo os valores da classe Livro
        public List<Livro> GetLivro()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "As brumas de Avalon I - A senhora" +
                "da Magia", 30.90m));
            livros.Add(new Livro("002", "Harry Potter e a Pedra Filosofal" +
                "", 25.00m));
            livros.Add(new Livro("003", "A Guerra dos Tronos", 30.99m));
            livros.Add(new Livro("004", "1984", 40.00m));

            return livros;
        }

    }
}
