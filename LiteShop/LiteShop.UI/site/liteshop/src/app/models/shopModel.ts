import GoodsModel from './goodsModel';

export default class ShopModel {
	ShopId: number;
	Name: string;
	Address: string;
	WorkingHours: string;
	GoodsItems: Array<GoodsModel>;


}
