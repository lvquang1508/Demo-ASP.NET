using ReponsitoryMVC.Models;

namespace ReponsitoryMVC.DAL
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        
        
    }
}
