import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import ShopModel from '../models/shopModel';

@Injectable()
export class ShopService {

  constructor(private http: Http) {

  }

  private baseUrl = 'http://10.143.12.113:4343/api/shops/';

  getShops(): Observable<ShopModel[]> {
    return this.http.get(this.baseUrl, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  saveShop(shop): Observable<any> {
    return this.http.patch(this.baseUrl, shop, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  saveGoods(goods): Observable<any> {
    return this.http.patch(this.baseUrl + 'goods', goods, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  deleteShop(id): Observable<any> {
    return this.http.delete(this.baseUrl + id, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  deleteGoods(id): Observable<any> {
    return this.http.delete(this.baseUrl + 'goods/' + id, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  addShop(shop): Observable<any> {
    return this.http.post(this.baseUrl, shop, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }

  addGoods(goods): Observable<any> {
    return this.http.post(this.baseUrl + 'goods/', goods, {
      headers: this.appendCORSHeaders()
    }).map(res => res.json());
  }




  private appendCORSHeaders(): Headers {
    return new Headers();
  }




}
