using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    public class Otherwise
    {
        public Otherwise()
        {
            Chooses = new List<Choose>();
            ItemGroups = new List<ItemGroup>();
            PropertyGroups = new List<PropertyGroup>();
        }

        public List<Choose> Chooses { get; set; }

        public List<ItemGroup> ItemGroups { get; set; }

        public List<PropertyGroup> PropertyGroups { get; set; }
    }
}
