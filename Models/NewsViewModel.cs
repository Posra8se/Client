namespace iSchool.Models
{
    /// <summary>
    /// View model containing news information to be displayed in the News view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for news data retrieved from the API and passed to the view.
    /// It contains an array of <see cref="NewsModel"/> objects representing older news articles.
    /// </remarks>
    public class NewsViewModel
    {
        /// <summary>
        /// Gets or sets the array of older news articles to be displayed.
        /// </summary>
        /// <value>
        /// An array of <see cref="NewsModel"/> objects, each containing details about a news article.
        /// This property can be null if no news data is available.
        /// </value>
        public NewsModel[]? Older { get; set; }
    }
}