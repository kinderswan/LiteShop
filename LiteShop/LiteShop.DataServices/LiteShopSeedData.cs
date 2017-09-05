using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.Models;

namespace LiteShop.DataServices
{
    public class LiteShopSeedData: CreateDatabaseIfNotExists<LiteShopEntities>
    {
        protected override void Seed(LiteShopEntities context)
        {
            context.Shops.AddRange(this.GetShopEntities());
            context.SaveChanges();
        }

        private IList<ShopEntity> GetShopEntities()
        {
            return new List<ShopEntity>
            {
                new ShopEntity()
                {
                    Address = "Makayenka str",
                    Name = "Barbeque Shop",
                    WorkingHours = "10.00 - 22.00",
                    GoodsItems = new List<GoodsItemEntity>
                    {
                        new GoodsItemEntity
                        {
                            Name = "Barbeque plate",
                            Description = "A plate to cook some meat"
                        }
                    }
                }
            };
        } 
    }
}
