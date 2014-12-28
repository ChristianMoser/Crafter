using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    public class ImportGroup
    {
        public ImportGroup()
        {
            Imports = new List<Import>();
        }

        public string Condition { get; set; }

        public List<Import> Imports { get; set; }
    }
}
