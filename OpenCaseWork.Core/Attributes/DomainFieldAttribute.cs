using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCaseWork.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    class DomainFieldAttribute: Attribute
    {
    }
}
