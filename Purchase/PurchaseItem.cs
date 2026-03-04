using Kassasystem1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Purchase
{
    public class PurchaseItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PriceType { get; set; }
        public int NumberOfItem { get; set; }
        public PurchaseItem(int id, int amount)
        {
            ID = id;
            NumberOfItem = amount;
            Name = IDsorting.GetProductFromId(id).ProductName;
            Price = IDsorting.GetProductFromId(id).ProductPrice;
            PriceType= IDsorting.GetProductFromId(id).ProductPriceType;
        }
    }
}
