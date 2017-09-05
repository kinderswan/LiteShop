using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Configuration;
using LiteShop.Models;
using LiteShop.Web.Models;

namespace LiteShop.Web.Registrars
{
    public static class MappingRegistrar
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(MappingRegistrar.GetMapperConfiguration());
        }

        private static MapperConfigurationExpression GetMapperConfiguration()
        {
            MapperConfigurationExpression configExpression = new MapperConfigurationExpression();

            configExpression.CreateMap<GoodsItemEntity, GoodsItemViewModel>();
            configExpression.CreateMap<GoodsItemViewModel, GoodsItemEntity>();

            configExpression.CreateMap<ShopEntity, ShopViewModel>();
            configExpression.CreateMap<ShopViewModel, ShopEntity>();

            return configExpression;
        }
    }
}