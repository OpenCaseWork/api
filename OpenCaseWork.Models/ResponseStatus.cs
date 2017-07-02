using System.Collections.Generic;

namespace OpenCaseWork.Models
{
    public class ResponseStatus
    {
        public int ErrorEnumId { get; set; }
        public int StatusCode { get; set; }

        /// <summary>
        /// A human friendly error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The Server StackTrace when DebugMode is enabled
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// For multiple detailed validation errors.
        /// Can hold a specific error message for each named field.
        /// </summary>
        public List<ResponseError> Errors { get; set; }

    }
}