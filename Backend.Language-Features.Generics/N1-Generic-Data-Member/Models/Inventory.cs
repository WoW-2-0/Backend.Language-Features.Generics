namespace N1_Generic_Data_Member.Models;

public class Inventory<T> where T : IInventoryItem
{
    public List<T> Items { get; set; } = new();
}