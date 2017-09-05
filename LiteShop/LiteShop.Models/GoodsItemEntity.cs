using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteShop.Models
{
    public class GoodsItemEntity
    {
        public int GoodsItemEntityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ShopEntityId { get; set; }

        public virtual ShopEntity ShopEntity { get; set; }


    }
}
