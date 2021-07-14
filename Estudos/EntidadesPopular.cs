using System;
using System.Collections.Generic;
using System.Linq;

namespace Estudos
{
    class EntidadesPopular
    {

        public static void EntidadesAdicionarDados()
        {
            using (var db = new EntidadesContext())
            {
                EntidadesPopularProdutos(db);
                EntidadesPopularCategorias(db);
            }
        }

        static void EntidadesPopularProdutos(EntidadesContext context)
        {
            if (!context.Produtos.Any())
            {
                Console.WriteLine("Adicionando Produtos...");
                var produtos = new List<Entidades.Produto>
                {
                    new Entidades.Produto {NomeItem = "Cream Cracker",PrecoItem=2.00,IDCategoria=0},
                    new Entidades.Produto {NomeItem = "Barra Chocolate", PrecoItem = 4.00, IDCategoria = 0},
                    new Entidades.Produto {NomeItem = "Nescau em Pó", PrecoItem = 8.00, IDCategoria = 0},
                    new Entidades.Produto {NomeItem = "Leite em Pó Itambé", PrecoItem = 5.00, IDCategoria = 0 }
                };
                context.AddRange(produtos);
                context.SaveChanges();
                Console.WriteLine("");
            }
        }

        static void EntidadesPopularCategorias(EntidadesContext context)
        {
            if (!context.Categorias.Any())
            {
                Console.WriteLine("Adicionando Categorias...");
                var categorias = new List<Entidades.Categoria>
                {
                    new Entidades.Categoria {NomeCategoria = "BISCOITOS" },
                    new Entidades.Categoria {NomeCategoria = "SOBREMESAS"},
                    new Entidades.Categoria {NomeCategoria = "LEITES"},
                    new Entidades.Categoria {NomeCategoria = "DOCES"},
                    new Entidades.Categoria {NomeCategoria = "SALGADOS"}

                };
                context.AddRange(categorias);
                context.SaveChanges();
                Console.WriteLine("");
            }
        }
    }
}

