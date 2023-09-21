using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Project.Models
{
    public abstract class Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
    }
}
