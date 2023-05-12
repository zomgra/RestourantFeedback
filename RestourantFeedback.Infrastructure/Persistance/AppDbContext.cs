using Microsoft.EntityFrameworkCore;
using RestourantFeedback.Application.Commons.Interfaces;
using RestourantFeedback.Domain;

namespace RestourantFeedback.Infrastructure.Persistance
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<FeedbackMessage> Feedbacks { get; set; }
    }
}
