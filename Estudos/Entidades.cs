using System;

namespace Estudos
{
    public class Entidades
    {
        public class Produto
        {
            public int ID { get; set; }
            public string NomeItem { get; set; }
            public double PrecoItem { get; set; }
            public int IDCategoria { get; set; }
        }

        public class Categoria
        {
            public int ID { get; set; }
            public string NomeCategoria { get; set; }
        }
    }
}
