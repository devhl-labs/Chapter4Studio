using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

#nullable enable

namespace Chapter4Studio
{
    public enum MenuCategory
    {
        None,
        Appetizer,
        MainCourse,
        Dessert
    }

    public class MenuItem
    {
        public string Name { get; }

        public double Price { get; set; }

        public string Description { get; } = string.Empty;

        public MenuCategory MenuCategory { get; }

        public DateTime CreatedAt { get; } = DateTime.UtcNow;

        public MenuItem(string name, double price, string description, MenuCategory menuCategory)
        {
            Name = name;

            Price = price;

            Description = description;

            MenuCategory = menuCategory;
        }

        public override string ToString()
        {
            return $"{Price:C} {Name}";
        }

        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Price == item.Price &&
                   Description == item.Description &&
                   MenuCategory == item.MenuCategory &&
                   CreatedAt == item.CreatedAt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
