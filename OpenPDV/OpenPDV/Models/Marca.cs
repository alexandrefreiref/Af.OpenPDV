using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenPDV.Models
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
