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

			configExpression.CreateMap<GoodsItemEntity, GoodsItemViewModel>()
				.ForMember(dest => dest.GoodsItemId, opt => opt.MapFrom(src => src.GoodsItemEntityId))
				.ForMember(dest => dest.ShopItemId, opt => opt.MapFrom(src => src.ShopEntityId));
			configExpression.CreateMap<GoodsItemViewModel, GoodsItemEntity>()
				.ForMember(dest => dest.GoodsItemEntityId, opt => opt.MapFrom(src => src.GoodsItemId))
				.ForMember(dest => dest.ShopEntityId, opt => opt.MapFrom(src => src.ShopItemId));

			configExpression.CreateMap<ShopEntity, ShopViewModel>()
				.ForMember(dest => dest.ShopId, opt => opt.MapFrom(src => src.ShopEntityId));
			configExpression.CreateMap<ShopViewModel, ShopEntity>()
				.ForMember(dest => dest.ShopEntityId, opt => opt.MapFrom(src => src.ShopId));

			return configExpression;
		}
	}
}