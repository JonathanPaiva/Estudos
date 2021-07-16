using System;
using System.Linq;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alimentando as tabelas do banco
            //EntidadesPopular.EntidadesAdicionarDados();

            //Alterando Dados
            //EntidadesAlterarDados.AlterarDados();

            //Excluíndo Dados
            //EntidadesExcluirDados.ExcluirDados();

            //Exibindo Dados das Tabelas
            EntidadesExibir.ExibirDados();

            /*//EntidadesCombinandoOperacoes.CombinandoOperacoes();
             * 
            Console.WriteLine("");
            Console.WriteLine("Dados Alterados!");
            Console.WriteLine("");

            EntidadesExibir.ExibirDados();*/

            Console.WriteLine("");
            Console.WriteLine("Precione 'Enter' para Finalizar.");
            Console.ReadLine();
        }
    }
}

