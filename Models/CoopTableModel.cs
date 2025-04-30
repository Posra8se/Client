namespace iSchool.Models
{
    /// <summary>
    /// Model representing the co-op table data with a title and collection of co-op information entries.
    /// </summary>
    /// <remarks>
    /// This model contains the data needed to populate the Co-Op Table, including a title for the table
    /// and an array of co-op information entries. Each entry represents a student's co-op placement.
    /// </remarks>
    public class CoopTableModel
    {
        /// <summary>
        /// Gets or sets the title of the co-op table.
        /// </summary>
        /// <value>A descriptive title for the co-op data table (e.g., "Student Co-op Placements").</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the array of co-op information entries to be displayed in the table.
        /// </summary>
        /// <value>
        /// An array of <see cref="CoopinformationModel"/> objects, each representing a student's co-op placement.
        /// </value>
        public CoopinformationModel[] coopInformation { get; set; }
    }
}