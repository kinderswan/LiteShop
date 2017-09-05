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
    public class GoodsItemEntityConfiguration : EntityTypeConfiguration<GoodsItemEntity>
    {
        public GoodsItemEntityConfiguration()
        {
            this.ToTable("Goods");
            this.HasKey(x => x.GoodsItemEntityId);
            this.Property(x => x.GoodsItemEntityId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
