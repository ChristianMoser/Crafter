using Crafter.Microsoft.MsBuild;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void CreateProject()
        {
            var project = new Project();
            project.Imports
            project.Save(@"C:\temp\test.csproj");
        }
    }
}
