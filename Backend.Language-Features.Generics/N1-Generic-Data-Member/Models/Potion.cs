namespace N1_Generic_Data_Member.Models;

public class Potion : IInventoryItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Health { get; set; }

    public Potion(string name, string description, int health)
    {
        Name = name;
        Description = description;
        Health = health;
    }

    public override string ToString()
    {
        return $"Name - {Name}, Description - {Description}, Health - {Health}";
    }
}