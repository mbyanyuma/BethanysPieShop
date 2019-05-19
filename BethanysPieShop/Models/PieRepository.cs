using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieDbContext _pieDbContext;

        public PieRepository(PieDbContext pieDbContext)
        {
            _pieDbContext = pieDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pieDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pieDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
