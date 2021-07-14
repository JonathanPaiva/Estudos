using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    class EntidadesExcluirDados
    {
        public static void ExcluirDados()
        {
            using (var db = new EntidadesContext())
            {
                ExlcuirProduto(db);
            }
        }

        static void ExlcuirProduto(EntidadesContext context)
        {
            var produto = context.Produtos.Find(1);

            if (produto is not null)
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
            } 
        }
    }
}
