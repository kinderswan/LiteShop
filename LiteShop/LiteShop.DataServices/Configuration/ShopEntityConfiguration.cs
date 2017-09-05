using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.Models;

namespace LiteShop.DataServices.Configuration
{
    public class ShopEntityConfiguration : EntityTypeConfiguration<ShopEntity>
    {
        public ShopEntityConfiguration()
        {
            this.ToTable("Shop");
            this.HasKey(x => x.ShopEntityId);
            this.Property(x => x.ShopEntityId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasMany(x => x.GoodsItems).WithRequired(x => x.ShopEntity).HasForeignKey(x => x.ShopEntityId);
        }
    }
}
