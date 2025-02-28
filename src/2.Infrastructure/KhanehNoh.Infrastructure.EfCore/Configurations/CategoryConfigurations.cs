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
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Categories");
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();

            builder.HasMany(x => x.SubCategories)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(new List<Category>
            {
                new Category {Id = 1 ,IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0), Title ="تمیزکاری"},
                new Category {Id = 2 , IsDeleted = false,RegisterAt = new DateTime(2025, 2, 16, 12, 45, 0),Title = "ساختمان", PictureUrl=""},


            });

        }
    }
}
