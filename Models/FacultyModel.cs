namespace iSchool.Models
{
    /// <summary>
    /// Model representing a single faculty member with detailed personal and professional information.
    /// </summary>
    /// <remarks>
    /// This model contains comprehensive information about a faculty member, including their name,
    /// academic title, contact information, research interests, and social media profiles.
    /// This information is used to display faculty profiles in the Faculty view.
    /// </remarks>
    public class FacultyModel
    {
        /// <summary>
        /// Gets or sets the username of the faculty member, often used as a unique identifier.
        /// </summary>
        /// <value>The unique username, typically used in URLs or as an ID.</value>
        public string username { get; set; }

        /// <summary>
        /// Gets or sets the full name of the faculty member.
        /// </summary>
        /// <value>The faculty member's full name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets a brief tagline or description about the faculty member.
        /// </summary>
        /// <value>A short phrase or sentence that describes the faculty member's focus or expertise.</value>
        public string tagline { get; set; }

        /// <summary>
        /// Gets or sets the path to the faculty member's profile image.
        /// </summary>
        /// <value>The relative or absolute URL to the faculty member's image.</value>
        public string imagePath { get; set; }

        /// <summary>
        /// Gets or sets the academic title or position of the faculty member.
        /// </summary>
        /// <value>The title (e.g., "Associate Professor" or "Department Chair").</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the research or teaching interest areas of the faculty member.
        /// </summary>
        /// <value>A description of the faculty member's academic and research interests.</value>
        public string interestArea { get; set; }

        /// <summary>
        /// Gets or sets the office location of the faculty member.
        /// </summary>
        /// <value>The building and room number or office identifier.</value>
        public string office { get; set; }

        /// <summary>
        /// Gets or sets the personal or professional website URL of the faculty member.
        /// </summary>
        /// <value>The full URL to the faculty member's website.</value>
        public string website { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the faculty member.
        /// </summary>
        /// <value>The contact phone number, typically the office phone.</value>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the email address of the faculty member.
        /// </summary>
        /// <value>The professional email address for contacting the faculty member.</value>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the Twitter/X profile URL of the faculty member.
        /// </summary>
        /// <value>The URL to the faculty member's Twitter/X profile.</value>
        public string twitter { get; set; }

        /// <summary>
        /// Gets or sets the Facebook profile URL of the faculty member.
        /// </summary>
        /// <value>The URL to the faculty member's Facebook profile.</value>
        public string facebook { get; set; }
    }
}