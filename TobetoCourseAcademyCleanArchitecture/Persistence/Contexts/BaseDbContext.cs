using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
	public class BaseDbContext : DbContext
	{
        public DbSet<Category> Categories { get; set; }
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }


        public BaseDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(a =>
            {
                a.ToTable("Categories").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Description).HasColumnName("Description");

            }); 


            
            Category[] categoryEntitySeeds = { new("brandName1", "brand1"), new("brandName2", "brand2") };
            categoryEntitySeeds[0].Id = Guid.NewGuid();
            categoryEntitySeeds[0].Id = Guid.NewGuid();
            modelBuilder.Entity<Category>().HasData(categoryEntitySeeds); 
             
        }

        /*
        protected IConfiguration Configuration { get; set; }
        public DbSet<Category> Categories { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(a =>
            {
                a.ToTable("Categories").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Description).HasColumnName("Description");

            });

            
            Category[] categoryEntitySeeds = { new("brandName1", "brand1"), new("brandName2", "brand2") };
            categoryEntitySeeds[0].Id = Guid.NewGuid();
            categoryEntitySeeds[0].Id = Guid.NewGuid();
            modelBuilder.Entity<Category>().HasData(categoryEntitySeeds);
 
        }*/
    }
}