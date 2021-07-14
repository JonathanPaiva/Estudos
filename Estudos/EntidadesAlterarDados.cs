using System;
using System.Linq;

namespace Estudos
{
    public class EntidadesAlterarDados
    {
        public static void AlterarDados()
        {
            using (var db = new EntidadesContext())
            {
                AlterarProdutos(db);
            }
        }

        static void AlterarProdutos(EntidadesContext context)
        {
            var produtos = context.Produtos.First();

            produtos.NomeItem = "Alterado";
            produtos.PrecoItem = 99.99;
            context.SaveChanges();
        }
    }
}
