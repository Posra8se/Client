namespace iSchool.Models
{
    /// <summary>
    /// Model representing the employment table data with a title and collection of professional employment information entries.
    /// </summary>
    /// <remarks>
    /// This model contains the data needed to populate the Employment Table, including a title for the table
    /// and an array of professional employment information entries. Each entry represents a graduate's employment details.
    /// </remarks>
    public class EmploymentTableModel
    {
        /// <summary>
        /// Gets or sets the title of the employment table.
        /// </summary>
        /// <value>A descriptive title for the employment data table (e.g., "Graduate Employment Information").</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the array of professional employment information entries to be displayed in the table.
        /// </summary>
        /// <value>
        /// An array of <see cref="EmploymentTableInformation"/> objects, each representing a graduate's employment details.
        /// </value>
        public EmploymentTableInformation[] professionalEmploymentInformation { get; set; }
    }
}