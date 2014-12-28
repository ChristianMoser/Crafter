﻿namespace Crafter.Microsoft.MsBuild
{
    public class UsingTask
    {
        public UsingTask()
        {
            Parameters = new ParameterGroup();
        }

        /// <summary>
        /// Either the AssemblyName attribute or the AssemblyFile attribute is required.
        /// The name of the assembly to load. The AssemblyName attribute accepts strong-named assemblies, although strong-naming is not required. Using this attribute is equivalent to loading an assembly by using the Load method in the .NET Framework.
        /// You cannot use this attribute if the AssemblyFile attribute is used.
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Either the AssemblyName or the AssemblyFile attribute is required.
        /// The file path of the assembly. This attribute accepts full paths or relative paths. Relative paths are relative to the directory of the project file or targets file where the UsingTask element is declared. Using this attribute is equivalent to loading an assembly by using the LoadFrom method in the .NET Framework.
        /// You cannot use this attribute if the AssemblyName attribute is used.
        /// </summary>
        public string AssemblyFile { get; set; }

        /// <summary>
        /// The name of the task to reference from an assembly. If ambiguities are possible, this attribute should always specify full namespaces. If there are ambiguities, MSBuild chooses an arbitrary match, which could produce unexpected results.
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Specifies the class in the assembly that is responsible for generating instances of the specified Task name.  The user may also specify a TaskBody as a child element that the task factory receives and uses to generate the task. The contents of the TaskBody are specific to the task factory.
        /// </summary>
        public string TaskFactory { get; set; }

        /// <summary>
        /// The condition to evaluate.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// The set of parameters that appear on the task that is generated by the specified TaskFactory.
        /// </summary>
        public ParameterGroup Parameters { get; set; }

        /// <summary>
        /// The data that is passed to the TaskFactory to generate an instance of the task.
        /// </summary>
        public TaskBody TaskBody { get; set; }
    }
}