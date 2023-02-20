using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage ="O tamanho maximo é 100 caracters")]
        [Required(ErrorMessage ="Informe o Nome da Categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }
        
        [StringLength(200, ErrorMessage = "O tamanho maximo é 100 caracters")]
        [Required(ErrorMessage = "Informe a descrição da Categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }


    }
}
