namespace iSchool.Models
{
    /// <summary>
    /// Model representing a single co-op placement entry with details about the student's employment.
    /// </summary>
    /// <remarks>
    /// This model contains information about an individual student's co-op placement,
    /// including the employer, the student's degree program, location, and the academic term
    /// during which the co-op took place.
    /// </remarks>
    public class CoopinformationModel
    {
        /// <summary>
        /// Gets or sets the name of the employer where the student completed their co-op.
        /// </summary>
        /// <value>The company or organization name.</value>
        public string employer { get; set; }

        /// <summary>
        /// Gets or sets the degree program of the student who completed the co-op.
        /// </summary>
        /// <value>The name of the degree program (e.g., "BS in Computing").</value>
        public string degree { get; set; }

        /// <summary>
        /// Gets or sets the city where the co-op placement was located.
        /// </summary>
        /// <value>The city and potentially state/country of the co-op location.</value>
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the academic term during which the co-op took place.
        /// </summary>
        /// <value>The term identifier (e.g., "Fall 2022" or "Spring 2023").</value>
        public string term { get; set; }
    }
}