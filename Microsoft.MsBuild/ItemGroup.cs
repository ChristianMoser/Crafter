using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    public class ItemGroup
    {
        public ItemGroup()
        {
            Items = new List<Item>();
        }

        public string Condition { get; set; }

        public List<Item> Items { get; set; } 
    }
}
