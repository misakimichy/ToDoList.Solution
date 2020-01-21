using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }

    public bool Done { get; set; }

    public DateTime Date { get; set; }

    public ICollection<CategoryItem> Categories { get;}

    public string SetDate()
    {
      return this.Date.ToString("yyyy-MM-dd");
    }
  }
}