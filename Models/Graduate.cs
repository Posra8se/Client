namespace iSchool.Models
{
    /// <summary>
    /// View model containing graduate program information to be displayed in the Graduate view.
    /// </summary>
    /// <remarks>
    /// This model is the main container for graduate program data retrieved from the API and passed to the view.
    /// It contains an array of <see cref="GraduateModel"/> objects, each representing a graduate program
    /// or a special category like "graduate advanced certificates".
    /// </remarks>
    public class GraduateViewModel
    {
        /// <summary>
        /// Gets or sets the array of graduate programs to be displayed.
        /// </summary>
        /// <value>
        /// An array of <see cref="GraduateModel"/> objects, each containing details about a graduate program.
        /// Some special items in this array may have different properties populated, such as the "graduate
        /// advanced certificates" item which has availableCertificates instead of concentrations.
        /// </value>
        public GraduateModel[] graduate { get; set; }
    }
}