using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    public class EntidadesExibir
    {
        public static void ExibirDados()
        {
            using (var db = new EntidadesContext())
            {
                var tblProdutos = db.Produtos.ToList();
                var tblCategorias = db.Categorias.ToList();

                if (tblProdutos.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-------------- Produtos Cadastrados --------------");

                    foreach (var listaProdutos in tblProdutos)
                    {

                        Console.WriteLine("Código: " + listaProdutos.ID + " - " + listaProdutos.NomeItem + "\t" + listaProdutos.PrecoItem.ToString("c"));

                    }
                }

                if (tblCategorias.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-------------- Categorias Cadastradas --------------");

                    foreach (var listaCategorias in tblCategorias)
                    {

                        Console.WriteLine("Código: " + listaCategorias.ID + "\t" + listaCategorias.NomeCategoria);

                    }
                }
            }
        }
    }
}

