using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Constituents
{
    public class EntityResponse<T>: BaseResponse
    {
        public T Data;
    }
}
