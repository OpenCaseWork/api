using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace OpenCaseWork.Core.Models
{
    public class BaseResponse
    {
        public BaseResponse()
        {
        }
 

        /// <summary>
        /// Is response Valid
        /// </summary>
        public ResponseStatus ResponseInfo { get; set; }



    }
}