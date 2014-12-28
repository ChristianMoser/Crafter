namespace Crafter.Microsoft.MsBuild
{
    public class Target
    {
        /// <summary>
        /// Required attribute. The name of the target.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The condition to be evaluated. If the condition evaluates to false, the target will not execute the body of the target or any targets that are set in the DependsOnTargets attribute.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// The files that form inputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in Outputs to determine whether the Target is up to date. 
        /// </summary>
        public string Inputs { get; set; }

        /// <summary>
        /// The files that form outputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in Inputs to determine whether the Target is up to date
        /// </summary>
        public string Outputs { get; set; }

        /// <summary>
        /// The set of items that will be made available to tasks that invoke this target, for example, MSBuild tasks. Multiple targets are separated by semicolons. If the targets in the file have no Returns attributes, the Outputs attributes are used instead for this purpose.
        /// </summary>
        public string Returns { get; set; }

        /// <summary>
        /// If true, multiple references to the same item in the target's Returns are recorded. By default, this attribute is false.
        /// </summary>
        public bool KeepDuplicateOutputs { get; set; }

        /// <summary>
        /// A semicolon-separated list of target names.  When specified, indicates that this target should run before the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly.
        /// </summary>
        public string BeforeTargets { get; set; }

        /// <summary>
        /// A semicolon-separated list of target names. When specified, indicates that this target should run after the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly.
        /// </summary>
        public string AfterTargets { get; set; }

        /// <summary>
        /// The targets that must be executed before this target can be executed or top-level dependency analysis can occur. Multiple targets are separated by semicolons.
        /// </summary>
        public string DependsOnTargets { get; set; }

        /// <summary>
        /// An identifier that can identify or order system and user elements.
        /// </summary>
        public string Label { get; set; } 
    }
}