using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDMVC.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Column("Id")]
        [DisplayName("Registro")]
        public int Id { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        public string Nome { get; set; } 
    }
}
