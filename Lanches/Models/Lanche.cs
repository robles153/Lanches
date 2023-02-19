namespace Lanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Name { get; set; }    
        public string DescricaoCurta { get; set; }
        public string Descricaodetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get;set; }
        public string ImagemThumbnaiUrl { get;set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
