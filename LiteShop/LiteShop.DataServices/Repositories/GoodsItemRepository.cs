﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.DataServices.Infrastructure;
using LiteShop.Models;

namespace LiteShop.DataServices.Repositories
{
    public class GoodsItemRepository: RepositoryBase<GoodsItemEntity>, IGoodsItemRepository
    {
        public GoodsItemRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
