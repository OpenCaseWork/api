﻿
using System.Collections.Generic;

namespace OpenCaseWork.Core.Models
{
    public class ResponseStatus
    {
        public string ErrorCode { get; set; }

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