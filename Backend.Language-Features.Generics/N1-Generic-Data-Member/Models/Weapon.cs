namespace N1_Generic_Data_Member.Models;

public class Weapon : IInventoryItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Damage { get; set; }

    public Weapon(string name, string description, int damage)
    {
        Name = name;
        Description = description;
        Damage = damage;
    }

    public override string ToString()
    {
        return $"Name - {Name}, Description - {Description}, Damage - {Damage}";
    }
}