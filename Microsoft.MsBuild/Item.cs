using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    public class Item
    {
        public Item()
        {
            ItemMetadata = new List<ItemMetadata>();
        }

        public string Include { get; set; }

        public string Exclude { get; set; }

        public string Condition { get; set; }

        public string Remove { get; set; }

        public bool KeepMetadata { get; set; }

        public bool RemoveMetadata { get; set; }

        public bool KeepDuplicates { get; set; }

        public List<ItemMetadata> ItemMetadata { get; set; }
    }
}
