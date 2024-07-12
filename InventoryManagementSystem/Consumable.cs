public class Consumable : InventoryItem
{
    public string ExpiryDate { get; set; }

    public Consumable(int id, string name, int quantity, decimal price, string expiryDate)
        : base(id, name, quantity, price)
    {
        ExpiryDate = expiryDate;
    }

    public override string GetItemType()
    {
        return "Consumable";
    }

    public override string ToString()
    {
        return $"{base.ToString()} | Expiry Date: {ExpiryDate}";
    }
}
