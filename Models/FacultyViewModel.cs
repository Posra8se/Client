namespace iSchool.Models
{
    /// <summary>
    /// View model containing faculty information to be displayed in the Faculty view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for faculty data retrieved from the API and passed to the view.
    /// It contains an array of <see cref="FacultyModel"/> objects, each representing a faculty member.
    /// </remarks>
    public class FacultyViewModel
    {
        /// <summary>
        /// Gets or sets the array of faculty members to be displayed.
        /// </summary>
        /// <value>
        /// An array of <see cref="FacultyModel"/> objects, each containing details about a faculty member.
        /// </value>
        public FacultyModel[] faculty { get; set; }
    }
}