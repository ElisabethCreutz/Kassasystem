using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    public class IDsorting
    {
        public static Product SelectedProduct { get; set; }
        public static int GetRecentProductId()
        {
            List<int> idList = new();
            foreach (var item in ProductDisplay.mainProductList)
            {
                idList.Add(item.ProductId);
            }
            idList.Sort();
            var last = idList.Count - 1;
            return idList[last];
        }
        public static Product GetProductFromId(int id)
        {
            //SelectedProduct = ProductDisplay.mainProductList.First(p => p.ProductId == id);
            SelectedProduct = ProductDisplay.mainProductList.Find(item => item.ProductId.Equals(id));
            return SelectedProduct;
        }
    }
}
