using Asm_PH26327.Models.IServices;


namespace Asm_PH26327.Models.Services
{
    public class ProductServices : IProductServices
    {
        ShopDbContext context;
        public ProductServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteProduct(Guid id)
        {
            try
            {
                dynamic product = context.Products.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Products.Remove(product);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductById(Guid id)
        {
            return context.Products.FirstOrDefault(pro => pro.id == id);
        }

        public List<Product> GetProductsByName(string name)
        {
            return context.Products.Where(pro => pro.Name.Contains(name)).ToList();
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                var pro = context.Products.Find(product.id);
                pro.Name = product.Name;
                pro.Color = product.Color;
                pro.Nsx = product.Nsx;
                pro.Size = product.Size;
                pro.Price = product.Price;
                pro.availabelQuantity = product.availabelQuantity;
                pro.status = product.status;
                pro.Supplier = product.Supplier;
                pro.Descreption = product.Descreption;
                pro.Hinhanh = product.Hinhanh;
                //có thể sửa thêm thuộc tính
                context.Products.Update(pro);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
