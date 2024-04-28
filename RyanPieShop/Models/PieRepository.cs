using Microsoft.EntityFrameworkCore;

namespace RyanPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly RyanPieShopDbContext _ryanPieShopDbContext;

        public PieRepository(RyanPieShopDbContext ryanPieShopDbContext) 
        {
            _ryanPieShopDbContext = ryanPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _ryanPieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _ryanPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
           return _ryanPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);    
        }
    }
}
