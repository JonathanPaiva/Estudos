using System;
using System.Collections.Generic;

namespace Estudos
{
    public class Entidades
    {
        public class Produto
        {
            public int ID { get; set; }
            public string NomeItem { get; set; }
            public double PrecoItem { get; set; }
            public Categoria Categoria { get; set; } //<<<<< Criar a Chave estrangeira
        }

        public class Categoria
        {
            public int ID { get; set; }
            public string NomeCategoria { get; set; }
            public ICollection<Produto>Produtos { get; set; } //Referencia a Tabela em questão no relacionamento 
            //Relacionamento de um-para-muitos
        }
    }
}
