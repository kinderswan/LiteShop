using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using LiteShop.Models;
using LiteShop.Services;
using LiteShop.Web.Models;
using Newtonsoft.Json;

namespace LiteShop.Web.Controllers
{
    [RoutePrefix("api")]
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
        [Route("shop/getAll")]
        public IHttpActionResult GetAllShops()
        {
            IList<ShopViewModel> result = Mapper.Map<IList<ShopEntity>, IList<ShopViewModel>>(this.mShopService.GetAll());

            return this.Json(result.ToList());
        }


    }
}
