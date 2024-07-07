# Inventory Management System

This project is a simple inventory management system implemented in C#. It allows you to manage a collection of inventory items, including both consumable and non-consumable items.

## Features

- Add new inventory items
- Remove existing inventory items
- List all inventory items

## Technologies Used

- C# programming language
- .NET Framework (or .NET Core/5/6)
- Visual Studio (or any other IDE with .NET support)

## Setup

To run this project locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/inventory-management.git
   cd inventory-management
    ```
2. **Open in Visual Studio**:

Open InventoryManagement.sln file in Visual Studio.
Build and Run:

3. **Build the solution** (Ctrl + Shift + B).
Set Program.cs as the startup file and run the project (`F5`).

## Usage
Usage
Once the project is running, you can interact with the inventory management system through the console:
- Add items: Use the AddItem method in Program.cs to add new InventoryItem objects.
- Remove items: Use the RemoveItem method in Program.cs to remove existing items by their ID.
- List inventory: The system lists all current inventory items after each action.
  Here's a simple example of adding and removing items:

  ``` csharp
  // Example usage in Program.cs
Inventory inventory = new Inventory();

// Adding items
inventory.AddItem(new InventoryItem(1, "Keyboard", 10, 19.99m));
inventory.AddItem(new InventoryItem(2, "Mouse", 15, 14.99m));
inventory.AddItem(new InventoryItem(3, "Monitor", 5, 129.99m));

// Displaying inventory
inventory.ListInventory();

// Removing an item
inventory.RemoveItem(2);

// Displaying inventory after removal
inventory.ListInventory();```

## Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or a pull request.
