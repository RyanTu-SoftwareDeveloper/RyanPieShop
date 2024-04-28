namespace RyanPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RyanPieShopDbContext _ryanPieShopDbContext;

        public CategoryRepository(RyanPieShopDbContext ryanPieShopDbContext)
        {
            _ryanPieShopDbContext = ryanPieShopDbContext;   
        }

        public IEnumerable<Category> AllCategories => 
            _ryanPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
