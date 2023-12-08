using System;
using Domain.Entities;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
	public class BaseDbContext : DbContext
	{
        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            //Database.Ensur eCreated();
        }

        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
