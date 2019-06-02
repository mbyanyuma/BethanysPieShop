using System.Collections.Generic;
using BethanysPieShop.Core.Models;

namespace BethanysPieShop.Data.Interfaces
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
