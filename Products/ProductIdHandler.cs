namespace Kassasystem1.Products
{
    public class ProductIdHandler
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
            SelectedProduct = ProductDisplay.mainProductList.Find(item => item.ProductId.Equals(id));
            return SelectedProduct;
        }
    }
}
