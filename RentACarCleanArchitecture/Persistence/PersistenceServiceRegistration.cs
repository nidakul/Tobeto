using System;
using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    //Extensions Method : Var olan bir classa dışardan yeni bir metod ekleyebiliriz.
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("nArchitecture"));
            services.AddScoped<IBrandRepository, BrandRepository>();
            return services;
        }
    }
}

