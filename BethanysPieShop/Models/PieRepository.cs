using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanyDbContext _bethanyDbContext;

        public PieRepository(BethanyDbContext bethanyDbContext)
        {
            _bethanyDbContext = bethanyDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _bethanyDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _bethanyDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
