namespace iSchool.Models
{
    /// <summary>
    /// View model containing co-op employment information to be displayed in the Co-Op Table view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for co-op data retrieved from the API and passed to the view.
    /// It acts as a wrapper for the <see cref="CoopTableModel"/> which contains the actual co-op details.
    /// </remarks>
    public class CoOpTableViewModel
    {
        /// <summary>
        /// Gets or sets the co-op table data containing the title and co-op information entries.
        /// </summary>
        /// <value>The co-op table model with detailed co-op information.</value>
        public CoopTableModel coopTable { get; set; }
    }
}