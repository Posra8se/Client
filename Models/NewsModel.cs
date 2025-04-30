namespace iSchool.Models
{
    /// <summary>
    /// Model representing a news article with details such as date, title, and description.
    /// </summary>
    /// <remarks>
    /// This model contains information about a single news article to be displayed in the News view.
    /// Each news article includes a date, title, and description.
    /// </remarks>
    public class NewsModel
    {
        /// <summary>
        /// Gets or sets the date when the news article was published.
        /// </summary>
        /// <value>
        /// The date of the news article in string format (e.g., "April 15, 2023").
        /// This property can be null.
        /// </value>
        public string? Date { get; set; }

        /// <summary>
        /// Gets or sets the title of the news article.
        /// </summary>
        /// <value>
        /// The headline or title of the news article.
        /// This property can be null.
        /// </value>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the description or content of the news article.
        /// </summary>
        /// <value>
        /// The main content or summary of the news article.
        /// This property can be null.
        /// </value>
        public string? Description { get; set; }
    }
}