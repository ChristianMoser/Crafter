﻿namespace Crafter.Microsoft.MsBuild
{
    /// <summary>
    /// Contains information about a specific parameter for a task that is generated by a UsingTask TaskFactory.  The name of the element is the name of the parameter. 
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// The .NET type of the parameter, for example, "System.String".
        /// </summary>
        public string ParameterType { get; set; }

        /// <summary>
        /// If true, this parameter is an output parameter for the task. By default, the value is false.
        /// </summary>
        public bool Output { get; set; }

        /// <summary>
        /// If true, this parameter is an required parameter for the task. By default, the value is false.
        /// </summary>
        public bool Required { get; set; }
    }
}
