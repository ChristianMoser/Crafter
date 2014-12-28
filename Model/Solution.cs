using System.Collections.Generic;

namespace Crafter.Model
{
    public class Solution
    {
        public Solution()
        {
            Tiers = new List<Tier>();
        }

        public string Name { get; set; }
        
        public string Root { get; set; }

        public List<Tier> Tiers { get; set; }
    }
}
