using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    public class Project
    {
        public Project()
        {
            Imports = new List<Import>();
            PropertyGroups = new List<PropertyGroup>();
        }

        public string DefaultTargets { get; set; }

        public string InitialTargets { get; set; }

        public string ToolsVersion { get; set; }

        public string TreatAsLocalProperty { get; set; }

        public List<Import> Imports { get; set; }

        public List<PropertyGroup> PropertyGroups { get; set; }
    }
}
