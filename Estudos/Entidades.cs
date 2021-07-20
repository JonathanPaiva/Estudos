using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estudos
{
    public class Entidades
    {
        public class Produto
        {
            public int ID { get; set; }
            
            //Configurações sobre o DataAnnotations
            [Required] // Propriedades 
            [StringLength(200)]  // Propriedades 
            public string NomeItem { get; set; }
            //-------------------------------------

            public double PrecoItem { get; set; }
            public Categoria Categoria { get; set; } //<<<<< Criar a Chave estrangeira
                                                     //se há um dbset com a entidade de categoria, não precisaria declarar a informação na entidade
        }

        public class Categoria
        {
            public int ID { get; set; }
            public string NomeCategoria { get; set; }
            public ICollection<Produto>Produtos { get; set; } //Referencia a Tabela em questão no relacionamento    
                                                              //Relacionamento de um-para-muitos
                                                              //Já está sendo declarado a informação referente ao DbSet com a inclusão do tipo de relacionamento na entidade em questão.
        }

        public class Aluno
        {
            public int AlunoID { get; set; }
            public string Nome { get; set; }
            public Equipamento Equipamento { get; set; } //Propriedade de navegação - Relacionamento um-para-um
        }

        public class Equipamento
        {
            public int EquipamentoID { get; set; }
            public string Nome { get; set; }
            public Aluno Aluno{ get; set; } //Propriedade de navegação - Relacionamento um-para-um
            public int AlunoID { get; set; } //Chave Estrangeira
        }
    }
}
