namespace iSchool.Models
{
    /// <summary>
    /// Model representing a single employment entry with details about a graduate's employment.
    /// </summary>
    /// <remarks>
    /// This model contains detailed information about an individual graduate's employment,
    /// including the employer name, degree obtained, location, job title, and start date.
    /// This information is used to populate the Employment Table and for filtering and visualization purposes.
    /// </remarks>
    public class EmploymentTableInformation
    {
        /// <summary>
        /// Gets or sets the name of the employer where the graduate is working.
        /// </summary>
        /// <value>The company or organization name.</value>
        public string employer { get; set; }

        /// <summary>
        /// Gets or sets the degree program completed by the graduate.
        /// </summary>
        /// <value>The name of the degree program (e.g., "MS in Computing").</value>
        public string degree { get; set; }

        /// <summary>
        /// Gets or sets the city where the employment is located.
        /// </summary>
        /// <value>The city and potentially state/country of the employment location.</value>
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the job title of the graduate's position.
        /// </summary>
        /// <value>The professional title or role (e.g., "Software Engineer").</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the date when the graduate started the position.
        /// </summary>
        /// <value>
        /// The start date of the employment, typically in a string format that can be parsed into a date.
        /// </value>
        public string startDate { get; set; }
    }
}