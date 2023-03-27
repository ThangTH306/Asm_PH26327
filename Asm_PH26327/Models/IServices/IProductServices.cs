namespace Asm_PH26327.Models.IServices
{
    public interface IProductServices
    {
        public bool CreateProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(Guid id);
        public List<Product> GetAllProducts();
        public Product GetProductById(Guid id);
        public List<Product> GetProductsByName(string name);
    }
}
