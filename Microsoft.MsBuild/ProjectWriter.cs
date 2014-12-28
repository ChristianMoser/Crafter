using System.Xml.Linq;

namespace Crafter.Microsoft.MsBuild
{
    public static class ProjectWriter
    {
        public static void Save(this Project project, string path)
        {
            var doc = new XDocument();
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";

            // <Project>-Root
            var projectElement = new XElement(ns + "Project");
            doc.Add(projectElement);

            // Properties
            var propertyGroupElement = new XElement(ns + "PropertyGroup");
            projectElement.Add(propertyGroupElement);

            foreach (var property in project.Properties)
            {
                propertyGroupElement.Add(new XElement(ns + property.Name, property.Value));    
            }

            doc.Save(path);
        }
    }
}
