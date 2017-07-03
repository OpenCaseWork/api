using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Models.Base
{
    public class BaseDomainsRequest
    {
        public string Resource;
    }

    public class BaseSearchRequest
    {
        public string Resource;
    }

    public class BaseSearchResponse<T> : BaseResponse
    {
        public List<T> Data;
    }

    public class BasePostResponse<T> : BaseResponse
    {
        public T Data;
    }

    public class BasePostRequest<T>
    {
        public T Data;
        public string Resource;
    }

}







