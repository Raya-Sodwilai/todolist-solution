using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // We add set; to the line below.
    public string Description { get; set; }
    private static List<Item> _instance = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instance.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instance;
    }

    public static void ClearAll()
    {
      _instance.Clear();
    }
  }
}