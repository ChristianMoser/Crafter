using System.Collections.Generic;

namespace Crafter.Microsoft.MsBuild
{
    /// <summary>
    /// Evaluates child elements to select one set of ItemGroup elements and/or PropertyGroup elements to evaluate.
    /// </summary>
    public class Choose
    {
        public Choose()
        {
            Whens = new List<When>();
        }

        /// <summary>
        /// Specifies a possible block of code for the Choose element to select. There may be one or more When elements in a Choose element.
        /// </summary>
        public List<When> Whens { get; set; }

        /// <summary>
        /// Specifies the block of code PropertyGroup and ItemGroup elements to evaluate if the conditions of all When elements evaluate to false.
        /// </summary>
        public Otherwise Otherwise { get; set; }
    }
}
