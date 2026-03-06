namespace Kassasystem1.Products
{
    public class Product
    {
        public static int LastUsedProductId = 0;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ProductPriceType { get; set; } = string.Empty;

        public Product(string productName, decimal price, string productPriceType)
        {
            ProductId = LastUsedProductId + 10;
            ProductName = productName;
            ProductPrice = price;
            ProductPriceType = productPriceType;
        }
        public Product(int productId, string productName, decimal productPrice, string productPriceType)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductPriceType = productPriceType;
        }
        public static int SetLastUsedProductId()
        {
            if (ProductDisplay.mainProductList.Count == 0)
            {
                LastUsedProductId = 0;
            }
            else
            {
                LastUsedProductId = ProductIdHandler.GetRecentProductId();
            }
            return LastUsedProductId;
        }
    }
}