
namespace OpenCaseWork.Models
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            this.ResponseInfo = new ResponseStatus();
        }
 

        /// <summary>
        /// Is response Valid
        /// </summary>
        public ResponseStatus ResponseInfo { get; set; }


    }
}