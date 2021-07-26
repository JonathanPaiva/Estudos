using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            [Column("NomeProduto")] // Propriedades - Nome da Coluna
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
            [Key] //Indica a Chave primária da tabela ignorando a convensão
            [DatabaseGenerated(DatabaseGeneratedOption.None)] //.Computed = Valor gerado ao salvar e regenerado ao ser atualizado / .Identity = Gerado pelo Banco de Dados na Adição / .None = não gera auto numeração
            public int Codigo { get; set; }
            [NotMapped] // Atributo não mapeia a informação da coluna e não cria ela no banco de dados. 
            public int AlunoID { get; set; }
            [Required] // Atributo exige o preenchimento da informação - not null
            [MaxLength(150)] //Define o tamanho máximo do campo
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

        public class Autor
        {
            public int AutorID { get; set; }
            public string Nome { get; set; }
            [ForeignKey("AutorFK")] // Pode ser definido de várias formas, neste caso, apenas utilizar a propriedade 'ForeignKey' Indicando qual é o nome da coluna da Entidade que está relacionada para vincular a chave estrangeira
            public ICollection<Livro> Livros { get; set; }
        }

        public class Livro
        {
            public int LivroID { get; set; }
            public string Nome { get; set; }
            public Autor Autor { get; set; }
            public int AutorFK { get; set; }
        }
    }
}
