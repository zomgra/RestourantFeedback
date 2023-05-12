using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestourantFeedback.Application.Commons.Interfaces;
using RestourantFeedback.Infrastructure.Persistance;

namespace RestourantFeedback.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(c=>c.UseInMemoryDatabase("DEV"));
            services.AddTransient<IAppDbContext, AppDbContext>();
            return services;
        }
    }
}
