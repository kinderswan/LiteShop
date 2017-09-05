using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.Models;

namespace LiteShop.Services
{
    public interface IGoodsService
    {
        void Add(GoodsItemEntity entity);

        void Update(GoodsItemEntity entity);

        void Delete(int id);

        GoodsItemEntity GetById(int id);

        IEnumerable<GoodsItemEntity> GetAll();

        void ApplyChanges();
    }
}
