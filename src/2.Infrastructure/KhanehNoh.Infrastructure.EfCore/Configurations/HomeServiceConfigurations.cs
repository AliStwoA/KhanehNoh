using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Configurations
{
    public class HomeServiceConfigurations : IEntityTypeConfiguration<HomeService>
    {
        public void Configure(EntityTypeBuilder<HomeService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("HomeServices");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.SubCategory)
               .WithMany(x => x.HomeServices)
               .HasForeignKey(x => x.SubCategoryId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Requests)
                .WithOne(x => x.HomeService)
                .HasForeignKey(x => x.HomeServiceId)
            .OnDelete(DeleteBehavior.Cascade);






            builder.HasData(new List<HomeService>
            {
                new HomeService{Id = 1, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 1, Title = "سرویس عادی نظافت", BasePrice = 300000},
                new HomeService{Id = 2, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 1, Title = "نظافت راه پله", BasePrice = 250000 },
                new HomeService{Id = 3, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 1, Title = "پذیرایی", BasePrice = 150000},

                new HomeService{Id = 5, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 2, Title = "قالی شویی", BasePrice = 300000},
                new HomeService{Id = 6, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 2, Title = "پرده شویی", BasePrice = 250000},
                new HomeService{Id = 7, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 2, Title = "خشک شویی", BasePrice = 150000},

                new HomeService{Id = 8, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 3, Title = "سرامیک خودرو", BasePrice = 300000},
                new HomeService{Id = 9, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 3, Title = "کارواش نانو", BasePrice = 250000},
                new HomeService{Id = 10, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 3, Title = "کارواش با آب", BasePrice = 150000},

                new HomeService{Id = 11, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 4, Title = "تعمیر و سرویس آبگرمکن", BasePrice = 300000},
                new HomeService{Id = 12, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 4, Title = "تعمیر و نگه داری موتورخانه", BasePrice = 250000},
                new HomeService{Id = 13, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 4, Title = "سرویس و تعمیر چیلر", BasePrice = 150000},

                new HomeService{Id = 14, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 5, Title = "پمپ و منبع آب", BasePrice = 300000},
                new HomeService{Id = 15, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 5, Title = "لوله کشی گاز", BasePrice = 250000},
                new HomeService{Id = 16, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 5, Title = "نصب و تعمیر سینک ظرفشویی", BasePrice = 150000},

                new HomeService{Id = 17, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 6, Title = "نصب لوستر و چراغ", BasePrice = 300000},
                new HomeService{Id = 18, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 6, Title = "کلید و پریز", BasePrice = 250000},
                new HomeService{Id = 19, IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), SubCategoryId = 6, Title = "سیم کشی و کابل کشی", BasePrice = 150000},


            });
        }
    }
}
