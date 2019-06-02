using BethanysPieShop.Core.Models;

namespace BethanysPieShop.Data.Interfaces
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
