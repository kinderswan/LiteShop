import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';

import ShopModel from '../models/shopModel';
import GoodsModel from '../models/goodsModel';

import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css'],
  providers: [ShopService]
})
export class ShopComponent implements OnInit {

  constructor(private shopService: ShopService) { }

  shopModelsDisplayed: ShopModel[];
  shopModel: ShopModel;
  goodsModel: GoodsModel;

  selectedShop: ShopModel;

  ngOnInit() {
    this.fetchAllShops();
    this.shopModel = new ShopModel();
    this.goodsModel = new GoodsModel();
  }

  private fetchAllShops(): void {
    this.shopService.getShops().subscribe(result => this.displayShops(result));
  }

  private displayShops(result: ShopModel[]) {
    this.shopModelsDisplayed = result;
  }

  saveShop(shop) {
    this.shopService.saveShop(shop).subscribe((result) => this.fetchAllShops());
  }

  deleteShop(shop: ShopModel) {
    this.shopService.deleteShop(shop.ShopId).subscribe((result) => this.fetchAllShops());
  }

  saveGoods(goods) {
    this.shopService.saveGoods(goods).subscribe((result) => this.fetchAllShops());
  }

  deleteGoods(goods: GoodsModel) {
    this.shopService.deleteGoods(goods.GoodsItemId).subscribe((result) => this.fetchAllShops());
  }

  addShop(shop) {
    this.shopService.addShop(shop).subscribe((result) => this.fetchAllShops());
  }

  addGoods(goods: GoodsModel) {
    goods.ShopItemId =  this.selectedShop.ShopId;
    this.shopService.addGoods(goods).subscribe((result) => this.fetchAllShops());
  }

}
