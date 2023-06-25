using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    [Table("Relationship")]
    public class Relationship1529465De1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int ProductId { get; set; }
        public int NumberOfProduct { get; set; }
    }
}
