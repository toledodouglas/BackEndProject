
using System.ComponentModel.DataAnnotations;


namespace BackEnd.Project.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido.")]
        [StringLength(12, ErrorMessage = "A descrição deve ter no máximo 12 caracteres")]
        public string CPF { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail informado não é válido.")]
        [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório.")]
        [RegularExpression(@"^\(\d{2}\) \d{4,5}-\d{4}$", ErrorMessage = "Celular inválido. Use o formato (DD) XXXXX-XXXX ou (DD) XXXXX-XXXXX.")]
        [StringLength(20, ErrorMessage = "A descrição deve ter no máximo 20 caracteres")]
        public string CellPhone { get; set; }

        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório.")]
        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        public string State { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        public string City { get; set; }
    }
}
