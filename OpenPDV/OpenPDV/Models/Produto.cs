using OpenPDV.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenPDV.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public ModoCadastro ModoCadastro { get; set; }

        public Produto ReferenciaProduto { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string CodigoExterno { get; set; }

        public Marca Marca { get; set; }  //gerenciar multi fornecedores

        public bool ControlarEstoque { get; set; }

        public string UnidadeMedida { get; set; }

        public int QuantidadeIdeal { get; set; }

        public decimal ValorVenda { get; set; }

        public string Observacao { get; set; }

        public Situacao Situacao { get; set; }
    }
}
