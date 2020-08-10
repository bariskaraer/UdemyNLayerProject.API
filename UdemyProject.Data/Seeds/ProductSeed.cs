using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyProject.Core.Models;

namespace UdemyProject.Data.Seeds
{
    class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;


        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1 , Name = "Pilot Kalem", Price=12.50m,Stock = 100, CategoryId = _ids[0]  },
                new Product { Id = 2, Name = "Kursun Kalem", Price = 42.50m, Stock = 200, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Tukenmez Kalem", Price = 32.50m, Stock = 300, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Defter", Price = 12.50m, Stock = 100, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Orta Defter", Price = 42.50m, Stock = 200, CategoryId = _ids[1] },
                new Product { Id = 6, Name = "Buyuk Defter", Price = 62.50m, Stock = 200, CategoryId = _ids[1] }
                );
        }
    }
}
