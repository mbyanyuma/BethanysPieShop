using BethanysPieShop.Core.Models;
using BethanysPieShop.Data.DataAccess;
using BethanysPieShop.Data.Interfaces;

namespace BethanysPieShop.Data.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly BethanyDbContext _bethanyDbContext;

        public FeedbackRepository(BethanyDbContext bethanyDbContext)
        {
            _bethanyDbContext = bethanyDbContext;
        }


        public void AddFeedback(Feedback feedback)
        {
            _bethanyDbContext.Feedbacks.Add(feedback);
            _bethanyDbContext.SaveChanges();
        }
    }
}