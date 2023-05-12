using Microsoft.EntityFrameworkCore;
using RestourantFeedback.Domain;

namespace RestourantFeedback.Application.Commons.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<FeedbackMessage> Feedbacks { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
