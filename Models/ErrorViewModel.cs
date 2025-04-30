namespace iSchool.Models
{
    /// <summary>
    /// View model containing error information to be displayed in the Error view.
    /// </summary>
    /// <remarks>
    /// This model is used to display error information to the user when an exception or error occurs
    /// during request processing. It includes a request ID that can be used for troubleshooting.
    /// </remarks>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the ID of the request that caused the error.
        /// </summary>
        /// <value>
        /// The unique identifier for the request, which can be used for logging and troubleshooting.
        /// This property can be null.
        /// </value>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether the request ID should be displayed to the user.
        /// </summary>
        /// <value>
        /// Returns true if the RequestId property has a value; otherwise, false.
        /// This is used to determine if the request ID section should be displayed in the error view.
        /// </value>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}