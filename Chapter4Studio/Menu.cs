using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;

namespace Chapter4Studio
{
    public class Menu
    {
        private Dictionary<string, MenuItem> MenuItems { get; } = new Dictionary<string, MenuItem>();

        public DateTime CreatedAt { get; }

        public DateTime ModifiedAt { get; }

        public string Name { get; }

        public Menu(string name, DateTime createdAt, DateTime modifiedAt)
        {
            Name = name;

            CreatedAt = createdAt;

            ModifiedAt = modifiedAt;
        }

        public bool AddItem(MenuItem menuItem) => MenuItems.TryAdd(menuItem.Name, menuItem);

        public ImmutableList<MenuItem> GetItems => MenuItems.Values.ToImmutableList();
    }
}
