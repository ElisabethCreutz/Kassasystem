using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Products
{
    internal class IDsorting
    {
        public static Product SelectedProduct {  get; set; }
        public static int GetRecentProductId()
        {
            List<int> idList = new();
            foreach (var item in ProductDisplay.mainProductList)
            {
                idList.Add(item.ProductId);
            }
            idList.Sort();
            var last = idList.Count - 1;
            return last;
        }
        public static bool FindProductID(int idNumber)
        {
            if (ProductDisplay.mainProductList[0] == null)
            {
                return false;
            }
            else
                foreach (var item in ProductDisplay.mainProductList)
                {
                    if (idNumber == item.ProductId)
                        return true;
                }
            return false;
        }
        public static void GetProductFromId(int idNumber)
        {
            foreach (var item in ProductDisplay.mainProductList)
            {
                if (idNumber == item.ProductId)
                    SelectedProduct = item;
            }

        }
    }
}
