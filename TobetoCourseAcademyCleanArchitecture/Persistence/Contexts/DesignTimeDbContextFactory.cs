using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Persistence.Contexts
{
    
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BaseDbContext>
    {
        public BaseDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BaseDbContext>();
            optionsBuilder.UseSqlServer("Server = localhost; Database = TobetoCourseAcademyOnion; User Id = SA; Password = rentacardb; TrustServerCertificate=true;");

            return new BaseDbContext(optionsBuilder.Options);
        }
    }
}


