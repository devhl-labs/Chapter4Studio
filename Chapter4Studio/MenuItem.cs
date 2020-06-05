using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

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

        public double Price { get; }

        public string Description { get; } = string.Empty;

        public MenuCategory MenuCategory { get; }

        public DateTime CreatedAt { get; }

        public MenuItem(string name, double price, string description, MenuCategory menuCategory, DateTime createdAt)
        {
            Name = name;

            Price = price;

            Description = description;

            MenuCategory = menuCategory;

            CreatedAt = createdAt;
        }
    }
}
