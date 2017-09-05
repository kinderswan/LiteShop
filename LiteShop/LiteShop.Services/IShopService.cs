using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.Models;

namespace LiteShop.Services
{
    public interface IShopService
    {
        void Add(ShopEntity entity);

        void Update(ShopEntity entity);

        void Delete(int id);

        ShopEntity GetById(int id);

        IList<ShopEntity> GetAll();

        void ApplyChanges();
    }
}
