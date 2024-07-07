public class NonConsumable : InventoryItem
{
    public string Material { get; set; }

    public NonConsumable(int id, string name, int quantity, decimal price, string material)
        : base(id, name, quantity, price)
    {
        Material = material;
    }

    public override string GetItemType()
    {
        return "Non-Consumable";
    }

    public override string ToString()
    {
        return $"{base.ToString()} | Material: {Material}";
    }
}
