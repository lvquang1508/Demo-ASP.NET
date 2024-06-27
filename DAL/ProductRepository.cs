using Microsoft.EntityFrameworkCore;
using ReponsitoryMVC.Models;

namespace ReponsitoryMVC.DAL
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Product> GetProducts()
        {
            return _dataContext.Products.ToList();
        }
    }
}
