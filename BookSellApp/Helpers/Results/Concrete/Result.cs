using BookSellApp.Helpers.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace BookSellApp.Helpers.Results.Concrete
{
    public abstract class Result : IResult
    {
        public string Message { get; }

        public bool IsSuccess { get; }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public Result(string message, bool isSuccess):this(isSuccess)
        {
          Message = message;
        }
    }
}