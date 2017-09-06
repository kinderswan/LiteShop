using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using LiteShop.Models;
using LiteShop.Services;
using LiteShop.Web.Models;
using Newtonsoft.Json;

namespace LiteShop.Web.Controllers
{
	[RoutePrefix("api")]
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class ShopController : ApiController
	{
		private readonly IShopService mShopService;

		private readonly IGoodsService mGoodsService;

		public ShopController(IShopService shopService, IGoodsService goodsService)
		{
			this.mShopService = shopService;
			this.mGoodsService = goodsService;
		}

		[HttpGet]
		[Route("shops")]
		public IHttpActionResult GetAllShops()
		{
			IList<ShopViewModel> result = Mapper.Map<IList<ShopEntity>, IList<ShopViewModel>>(this.mShopService.GetAll());

			return this.Json(result.ToList());
		}

		[HttpPatch]
		[Route("shops")]
		public IHttpActionResult SaveShopModel(ShopViewModel model)
		{
			var savingModel = Mapper.Map<ShopViewModel, ShopEntity>(model);
			this.mShopService.Update(savingModel);
			return this.Ok("Saved");
		}

		[HttpPatch]
		[Route("shops/goods")]
		public IHttpActionResult SaveGoodsModel(GoodsItemViewModel model)
		{
			var savingModel = Mapper.Map<GoodsItemViewModel, GoodsItemEntity>(model);
			this.mGoodsService.Update(savingModel);
			return this.Ok("Saved");
		}

		[HttpPost]
		[Route("shops")]
		public IHttpActionResult AddShopModel(ShopViewModel model)
		{
			var savingModel = Mapper.Map<ShopViewModel, ShopEntity>(model);
			this.mShopService.Add(savingModel);
			return this.Ok("Added");
		}

		[HttpPost]
		[Route("shops/goods")]
		public IHttpActionResult AddGoodsModel(GoodsItemViewModel model)
		{
			var savingModel = Mapper.Map<GoodsItemViewModel, GoodsItemEntity>(model);
			this.mGoodsService.Add(savingModel);
			return this.Ok("Added");
		}

		[HttpDelete]
		[Route("shops/{id}")]
		public IHttpActionResult DeleteShopById(int id)
		{
			this.mShopService.Delete(id);
			return this.Ok("Deleted");
		}

		[HttpDelete]
		[Route("shops/goods/{id}")]
		public IHttpActionResult DeleteGoodsById(int id)
		{
			this.mGoodsService.Delete(id);
			return this.Ok("Deleted");
		}


	}
}
