using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        // Adding items
        inventory.AddItem(new Consumable(1, "Apple", 10, 1.99m, "2024-07-31"));
        inventory.AddItem(new Consumable(2, "Bread", 5, 2.49m, "2024-07-15"));
        inventory.AddItem(new NonConsumable(3, "Laptop", 3, 799.99m, "Aluminum"));

        // Displaying inventory
        inventory.ListInventory();

        // Removing an item
        inventory.RemoveItem(2);

        // Displaying inventory after removal
        inventory.ListInventory();
    }
}
