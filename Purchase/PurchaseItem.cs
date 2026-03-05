using Kassasystem1.Products;

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
            Name = ProductIdHandler.GetProductFromId(id).ProductName;
            Price = ProductIdHandler.GetProductFromId(id).ProductPrice;
            PriceType = ProductIdHandler.GetProductFromId(id).ProductPriceType;
        }
    }
}
