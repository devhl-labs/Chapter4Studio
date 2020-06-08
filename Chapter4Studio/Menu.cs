using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;

#nullable enable

namespace Chapter4Studio
{
    public class Menu
    {
        private Dictionary<string, MenuItem> MenuItems { get; } = new Dictionary<string, MenuItem>();

        public DateTime CreatedAt { get; } = DateTime.UtcNow;

        public DateTime ModifiedAt { get; private set; } = DateTime.UtcNow;

        public string Name { get; }

        public Menu(string name)
        {
            Name = name;
        }

        public bool AddItem(MenuItem menuItem)
        {
            ModifiedAt = DateTime.UtcNow;

            return MenuItems.TryAdd(menuItem.Name, menuItem);
        }

        public bool RemoveItem(MenuItem menuItem)
        {
            ModifiedAt = DateTime.UtcNow;

            return MenuItems.Remove(menuItem.Name);
        }

        public ImmutableArray<MenuItem> Items => MenuItems.Values.ToImmutableArray();

        public override string ToString()
        {
            if (MenuItems.Count == 0)
                return "This menu is empty.";

            string? result = $"**{Name.ToUpper()} MENU**\n";

            foreach (MenuItem menuItem in MenuItems.Values.OrderBy(i => i.Name))
                result += $"{menuItem}\n";

            return result ?? "This menu is empty.";            
        }
    }
}
