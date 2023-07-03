﻿

namespace BurgerApp.Helpers
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using BurgerApp.DataAccess.DataContext;
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.DataAccess.Repositories.Implementations;
    using BurgerApp.Domain.Models;
    using BurgerApp.Services.Impelmentations;
    using BurgerApp.Services.Interfaces;

    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services)
        {
            services.AddDbContext<BurgerAppDbContext>(options => options.UseSqlServer(@"Data Source=(localdb)\BurgerApp;Database=BurgerAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Burger>, BurgerRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
        }
    }
}
