using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.DataServices.Configuration;
using LiteShop.Models;

namespace LiteShop.DataServices
{
    public class LiteShopEntities : DbContext
    {

        public LiteShopEntities() : base("LiteShopEntities") { }

        public LiteShopEntities(string connectionString) : base(connectionString) { }

        public DbSet<ShopEntity> Shops { get; set; }

        public DbSet<GoodsItemEntity> GoodsItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShopEntityConfiguration());
            modelBuilder.Configurations.Add(new GoodsItemEntityConfiguration());
        }
    }
}
