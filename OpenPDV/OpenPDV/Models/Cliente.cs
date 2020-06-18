using System;
using System.ComponentModel.DataAnnotations;

namespace OpenPDV.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

        [MaxLength(50)]
        public string NomeRazaoSocial { get; set; }

        [MaxLength(50)]
        public string CpfCnpj { get; set; }

        [MaxLength(50)]
        public string RgInscricaoEstadual { get; set; }

        [MaxLength(30)]
        public string Telefone { get; set; }

        [MaxLength(80)]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public Cidade Cidade { get; set; }

        public string CEP { get; set; }

        public string Endereco { get; set; }

        public string EnderecoNumero { get; set; }

        public string Bairro { get; set; }

        public string EnderecoReferencia { get; set; }

        public string Observacao { get; set; }

        public bool Ativo { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }

    public enum TipoPessoa {FISICA,JURIDICA};
}
