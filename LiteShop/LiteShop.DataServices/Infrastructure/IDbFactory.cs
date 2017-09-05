using System;

namespace LiteShop.DataServices.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LiteShopEntities Init();
    }
}