using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [Required(ErrorMessage ="o nome do lanche é obrigatorio")]
        [Display(Name ="Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve ser no minimo {1} e no maximo 80 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A descrição do lanche é obrigatoria")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage ="descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="Descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição detalhada do lanche é obrigatoria")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]
        public string Descricaodetalhada { get; set; }
        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="o preço de estar entre 1 e 999,99")]

        public decimal Preco { get; set; }
        [Display(Name ="Caminho da imagem Normal")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no maximo {1} caracteres")]
        public string ImagemUrl { get;set; }
        [Display(Name = "Caminho da imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImagemThumbnaiUrl { get;set; }
        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
