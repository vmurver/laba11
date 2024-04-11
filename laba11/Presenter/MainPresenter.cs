
using ClothesShop.Model;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ClothesShop.View;

namespace ClothesShop.Presenter
{
    public class MainPresenter
    {
        private IFormView view;
        private List<Goods> GoodsList;
        private OnlineShop shop;
        public MainPresenter(IFormView view)
        {
            this.view = view;
            this.GoodsList = new List<Goods>();
            this.shop = new OnlineShop();
        }
        public void SetOnlineShop(OnlineShop shop)
        {
            this.shop = shop;
        }
        public void DisplayMessage(string message)
        {
            view.DisplayMessage(message);

        }
        public void UpdateOrderSummary(double totalAmount)
        {
            view.UpdateOrderSummary(totalAmount);
            shop.Sale(totalAmount);
            shop.Sum(totalAmount);
            shop.Add_order(totalAmount);
        }
        public void AddGoods(Goods goods)
        {
            GoodsList.Add(goods);
            view.SetDataSource(GoodsList);
        }
        public void AddClothes(string name, string brand, string color, string
       type, int size, double price)
        {
            Clothes clothes = new Clothes(name, brand, color, type, size,
           price);
            AddGoods(clothes);
        }
        public void AddShoes(string name, string brand, string color, string
        type, int size, double price)
        {
            Shoes shoes = new Shoes(name, brand, color, type, size,
           price);
            AddGoods(shoes);
        }

        public void AddAccessories(string name, string brand, string color, string
        type, int size, double price)
        {
            Accessories accessories = new Accessories(name, brand, color, type, size,
           price);
            AddGoods(accessories);
        }
    }
 }
