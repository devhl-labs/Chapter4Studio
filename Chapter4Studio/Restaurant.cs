using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4Studio
{
    public class Restaurant
    {
        public void Open()
        {
            Menu menu = new Menu("Desserts");

            menu.AddItem(new MenuItem("ice cream", 1, "just some ice cream", MenuCategory.Dessert));
            menu.AddItem(new MenuItem("pudding", .99, "just some ice cream", MenuCategory.Dessert));
            menu.AddItem(new MenuItem("popsicle", .50, "just some ice cream", MenuCategory.Dessert));
            menu.AddItem(new MenuItem("apple pie", 4, "just some ice cream", MenuCategory.Dessert));

            Console.WriteLine(menu);
            Console.WriteLine();
            Console.WriteLine(menu.Items.First());
            Console.WriteLine();
            menu.RemoveItem(menu.Items.First());
            Console.WriteLine(menu);
        }
    }
}
