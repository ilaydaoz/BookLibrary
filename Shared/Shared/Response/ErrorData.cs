using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Response
{
    public class ErrorData<T> : DataResult<T>
    {
        public ErrorData(T data, string message) : base(data, false, message)
        {

        }

        public ErrorData(T data) : base(data, false)
        {

        }
    }
}
