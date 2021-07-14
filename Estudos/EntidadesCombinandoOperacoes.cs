using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    public class EntidadesCombinandoOperacoes
    {
        public static void CombinandoOperacoes()
        {
            using (var db = new EntidadesContext())
            {

                //Adicionando produto
                Console.WriteLine("");
                Console.WriteLine("Adicionando Produto Novo...");
                var produtoNovo = new Entidades.Produto
                {
                    NomeItem = "Produto Novo",
                    PrecoItem = 11.11,
                    IDCategoria = 0
                };
                db.Produtos.Add(produtoNovo);
                Console.WriteLine("");

                //Editando produto
                var primeiroProduto = db.Produtos.First();
                primeiroProduto.NomeItem = "ALTERADO";

                //Excluindo produto
                var ultimoProduto = db.Produtos.Find(3);
                if (ultimoProduto is not null)
                {
                    db.Produtos.Remove(ultimoProduto);
                }
                
                db.SaveChanges();
            }
        }

    }
}
