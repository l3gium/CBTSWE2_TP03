using System.ComponentModel.DataAnnotations;

namespace CBTSWE2_TP03.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public double Preco { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade no estoque não pode ser negativa")]
        public int QtdEstoque { get; set; }
    }
}
