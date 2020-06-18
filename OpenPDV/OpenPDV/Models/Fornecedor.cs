using OpenPDV.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPDV.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Cidade Cidade { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string Bairro { get; set; }
        public string EnderecoReferencia { get; set; }
        public string RepresentanteNome { get; set; }
        public string RepresentanteTelefone { get; set; }
        public string RepresentanteEmail { get; set; }
        public string Observacao { get; set; }
        public Situacao Situacao { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}
