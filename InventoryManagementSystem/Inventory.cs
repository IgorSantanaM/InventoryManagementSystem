public class Inventory
{
    private List<InventoryItem> items;

    public Inventory()
    {
        items = new List<InventoryItem>();
    }

    public void AddItem(InventoryItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(int itemId)
    {
        InventoryItem itemToRemove = items.Find(item => item.Id == itemId);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
        else
        {
            Console.WriteLine($"Item with ID {itemId} not found.");
        }
    }

    public void ListInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in items)
        {
            Console.WriteLine($"[{item.GetItemType()}] {item}");
        }
    }
}
