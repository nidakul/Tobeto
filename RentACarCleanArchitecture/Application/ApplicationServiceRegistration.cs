﻿using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    //IOC servis kayıtlarını buraya ekliyoruz. Bağımlılıkları yönetmek ve enjekte etmek
    //Commandlerin Handler'larını buluyor.
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}


