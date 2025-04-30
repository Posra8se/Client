namespace iSchool.Models
{
    /// <summary>
    /// Model representing an undergraduate program with detailed information about the degree.
    /// </summary>
    /// <remarks>
    /// This model contains comprehensive information about an undergraduate program, including its name,
    /// title, description, and available concentrations.
    /// </remarks>
    public class UndergraduateModel
    {
        /// <summary>
        /// Gets or sets the degree name of the undergraduate program.
        /// </summary>
        /// <value>
        /// The short code or identifier for the degree (e.g., "wmc", "hcc", "cit").
        /// </value>
        public string degreeName { get; set; }

        /// <summary>
        /// Gets or sets the full title of the undergraduate program.
        /// </summary>
        /// <value>
        /// The complete title of the program (e.g., "Web &amp; Mobile Computing, B.S.").
        /// </value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the description of the undergraduate program.
        /// </summary>
        /// <value>
        /// A detailed description of the program, its focus, and its benefits.
        /// </value>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the array of available concentrations within the undergraduate program.
        /// </summary>
        /// <value>
        /// An array of strings, each representing a concentration option within the program.
        /// </value>
        public string[] concentrations { get; set; }
    }
}