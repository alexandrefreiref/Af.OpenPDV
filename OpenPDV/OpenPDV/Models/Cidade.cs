using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPDV.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        [MaxLength(2)]
        public string UF { get; set; }
        
        public string IBGE { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}
