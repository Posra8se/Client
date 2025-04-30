namespace iSchool.Models
{
    /// <summary>
    /// View model containing undergraduate program information to be displayed in the Undergraduate view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for undergraduate program data retrieved from the API and passed to the view.
    /// It contains an array of <see cref="UndergraduateModel"/> objects, each representing an undergraduate program.
    /// </remarks>
    public class UndergraduateViewModel
    {
        /// <summary>
        /// Gets or sets the array of undergraduate programs to be displayed.
        /// </summary>
        /// <value>
        /// An array of <see cref="UndergraduateModel"/> objects, each containing details about an undergraduate program.
        /// </value>
        public UndergraduateModel[] undergraduate { get; set; }
    }
}