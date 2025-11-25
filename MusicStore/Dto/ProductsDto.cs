using MusicStore.Models;

namespace MusicStore.Dto
{
    public class ProductsDto
    {
    }
    public class ProductsWithCategoriesDto
    {
        public string Name { get; set; }
        public string Category  { get; set; }
        public List<string> SubCategory { get; set; }
    }

     public class CreateProductDto
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Quentity {  get; set; }
    }
}
