namespace TheOrderRestaurantProject.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Prato> Pratos { get; set; } // Pratos N ----- 1 Categoria
    }
}
