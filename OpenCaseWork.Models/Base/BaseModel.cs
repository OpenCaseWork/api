using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Base
{
    public class BaseDomainsRequest
    {
        public string Resource;
    }

    public class BaseDomainsResponse: BaseResponse
    {
        public object Data;
    }

    public class BaseSearchRecord
    {
    }

    public class BaseSearchRequest
    {
        public string Resource;
    }

    public class BaseSearchResponse<T> : BaseResponse
    {
        public List<T> Data;
    }
}




 


