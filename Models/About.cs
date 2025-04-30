namespace iSchool.Models
{
    /// <summary>
    /// View model representing the information displayed on the About (home) page of the iSchool website.
    /// </summary>
    /// <remarks>
    /// This model contains basic information about the school, including the title, description,
    /// and a featured quote with its author. This data is fetched from the API and displayed on the index page.
    /// </remarks>
    public class AboutViewModel
    {
        /// <summary>
        /// Gets or sets the title displayed at the top of the About page.
        /// </summary>
        /// <value>The title of the school or department.</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the main description text for the school or department.
        /// </summary>
        /// <value>A detailed description of the school, its mission, or its programs.</value>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets a featured quote to be displayed on the About page.
        /// </summary>
        /// <value>A quote that represents the school's values or mission.</value>
        public string quote { get; set; }

        /// <summary>
        /// Gets or sets the author of the featured quote.
        /// </summary>
        /// <value>The name of the person who said or wrote the quote.</value>
        public string quoteAuthor { get; set; }
    }
}