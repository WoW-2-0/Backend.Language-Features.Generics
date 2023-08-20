using N1_Generic_Data_Member.Models;

var inventory = new Inventory<IInventoryItem>();

// As the Inventory class is generic, we can add any type of item to it
inventory.Items.Add(new Potion("Health Potion", "Restores health", 50));
inventory.Items.Add(new Potion("Mana Potion", "Restores mana", 50));
inventory.Items.Add(new Treasure("Gold Coin", "A shiny gold coin", 10));
inventory.Items.Add(new Treasure("Diamond", "A valuable diamond", 100));
inventory.Items.Add(new Weapon("Sword", "A sharp sword", 20));
inventory.Items.Add(new Weapon("Axe", "A heavy axe", 30));
inventory.Items.Add(new Potion("Elixir of Strength", "Increases strength", 10));
inventory.Items.Add(new Potion("Elixir of Agility", "Increases agility", 10));
inventory.Items.Add(new Treasure("Silver Ring", "A beautiful silver ring", 50));
inventory.Items.Add(new Treasure("Emerald", "A precious emerald", 75));
inventory.Items.Add(new Weapon("Mace", "A blunt mace", 25));
inventory.Items.Add(new Weapon("Dagger", "A sharp dagger", 15));
inventory.Items.Add(new Potion("Elixir of Intelligence", "Increases intelligence", 10));
inventory.Items.Add(new Potion("Elixir of Wisdom", "Increases wisdom", 10));
inventory.Items.Add(new Treasure("Ruby", "A valuable ruby", 100));

Console.WriteLine("Weapons : ");
foreach (var item in inventory.Items.OfType<Weapon>())
    Console.WriteLine(item);

Console.WriteLine("Potions : ");
foreach (var item in inventory.Items.OfType<Potion>())
    Console.WriteLine(item);

Console.WriteLine("Treasures : ");
foreach (var item in inventory.Items.OfType<Treasure>())
    Console.WriteLine(item);