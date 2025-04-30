namespace iSchool.Models
{
    /// <summary>
    /// Model representing a graduate program with detailed information about the degree.
    /// </summary>
    /// <remarks>
    /// This model contains comprehensive information about a graduate program, including its name,
    /// title, description, available concentrations, and certificates.
    /// 
    /// The model has a special case for "graduate advanced certificates" where the degreeName is 
    /// "graduate advanced certificates" and only the availableCertificates property is populated
    /// (title, description, and concentrations are null for this case).
    /// </remarks>
    public class GraduateModel
    {
        /// <summary>
        /// Gets or sets the degree name of the graduate program.
        /// </summary>
        /// <value>
        /// The short code or identifier for the degree (e.g., "ist", "hci", "nsa").
        /// Special case: "graduate advanced certificates" for the certificates listing.
        /// </value>
        public string degreeName { get; set; }

        /// <summary>
        /// Gets or sets the full title of the graduate program.
        /// </summary>
        /// <value>
        /// The complete title of the program (e.g., "Information Sciences &amp; Technologies, M.S.").
        /// May be null for special cases like "graduate advanced certificates".
        /// </value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the description of the graduate program.
        /// </summary>
        /// <value>
        /// A detailed description of the program, its focus, and its benefits.
        /// May be null for special cases like "graduate advanced certificates".
        /// </value>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the array of available concentrations within the graduate program.
        /// </summary>
        /// <value>
        /// An array of strings, each representing a concentration option within the program.
        /// May be null for special cases like "graduate advanced certificates".
        /// </value>
        public string[] concentrations { get; set; }

        /// <summary>
        /// Gets or sets the array of available certificates.
        /// </summary>
        /// <value>
        /// An array of strings, each representing an available certificate.
        /// This is typically only populated for the special "graduate advanced certificates" item.
        /// </value>
        public string[] availableCertificates { get; set; }
    }
}