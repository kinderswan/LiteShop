using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteShop.Models
{
    public class ShopEntity
    {
        public int ShopEntityId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string WorkingHours { get; set; }
        
        public virtual ICollection<GoodsItemEntity> GoodsItems { get; set; }
    }
}
