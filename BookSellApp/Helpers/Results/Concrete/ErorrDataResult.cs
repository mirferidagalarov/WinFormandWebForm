using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Helpers.Results.Concrete
{
    public class ErorrDataResult<T> : DataResult<T>
    {
        public ErorrDataResult(T data) : base(data, false)
        {
        }

        public ErorrDataResult(T data, string message) : base(data, message, false)
        {
        }
    }
}