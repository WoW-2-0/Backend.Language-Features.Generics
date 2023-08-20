namespace N1_Generic_Data_Member.Models;

public class Treasure : IInventoryItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public Treasure(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    public override string ToString()
    {
        return $"Name - {Name}, Description - {Description}, Value - {Value}";
    }
}