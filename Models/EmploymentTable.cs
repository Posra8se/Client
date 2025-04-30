namespace iSchool.Models
{
    /// <summary>
    /// View model containing employment information to be displayed in the Employment Table view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for employment data retrieved from the API and passed to the view.
    /// It acts as a wrapper for the <see cref="EmploymentTableModel"/> which contains the actual employment details.
    /// </remarks>
    public class EmploymentTableViewModel
    {
        /// <summary>
        /// Gets or sets the employment table data containing the title and professional employment information entries.
        /// </summary>
        /// <value>The employment table model with detailed employment information of graduates.</value>
        public EmploymentTableModel employmentTable { get; set; }
    }
}