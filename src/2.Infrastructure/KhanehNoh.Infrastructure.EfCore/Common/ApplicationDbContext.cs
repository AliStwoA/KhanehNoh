using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Entities.Categories;
using KhanehNoh.Domain.Core.Entities.Orders;
using KhanehNoh.Domain.Core.Entities.Users;
using KhanehNoh.Infrastructure.EfCore.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhanehNoh.Infrastructure.EfCore.Configurations;

namespace KhanehNoh.Infrastructure.EfCore.Common
{
    public class ApplicationDbContext : IdentityDbContext<User , IdentityRole<int>, int >
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    base.OnConfiguring(builder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            UserConfigurations.Configuration(modelBuilder);
            modelBuilder.ApplyConfiguration(new HomeServiceConfigurations());
            modelBuilder.ApplyConfiguration(new SubCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CityConfigurations());
            modelBuilder.ApplyConfiguration(new RequestConfigurations());
            modelBuilder.ApplyConfiguration(new OfferConfigurations());
            modelBuilder.ApplyConfiguration(new RatingConfigurations());
            modelBuilder.ApplyConfiguration(new AdminConfigurations());
            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new ExpertConfigurations());
            base.OnModelCreating(modelBuilder);







        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<HomeService> HomeServices { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    }
}
