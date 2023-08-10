
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BackEnd.Project.Models
{
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória")]
        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Informe o preço do Lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "0 {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Quantidade em estoque")]
        [Required(ErrorMessage = "O estoque é obrigatório.")]
        public int Quantity { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }

        public List<Product> Products { get; set; }
    }
}
