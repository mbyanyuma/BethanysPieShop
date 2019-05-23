using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
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