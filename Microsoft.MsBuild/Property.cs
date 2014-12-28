namespace Crafter.Microsoft.MsBuild
{
    public class Property
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the property.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Condition to be evaluated.
        /// </summary>
        public string Condition { get; set; }
    }
}