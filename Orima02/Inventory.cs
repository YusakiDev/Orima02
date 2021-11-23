using System;

namespace Orima02
{
    public class Inventory
    {
        public Item[] Items;

        public Inventory(Item[] items)
        {
            Items = items;
        }




        public void OpenInvetory()
        {
            
            Console.WriteLine("{0}" , string.Join(", ", (object) Items));
        }
    }
}