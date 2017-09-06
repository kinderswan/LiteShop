using System.Collections.Generic;

namespace LiteShop.Web.Models
{
	public class ShopViewModel
	{
		public int ShopId { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public string WorkingHours { get; set; }

		public ICollection<GoodsItemViewModel> GoodsItems { get; set; }
	}
}
