using BookSellApp.Helpers.Results.Abstract;
using BookSellApp.Helpers.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Helpers
{
    public static class BusinessLogics
    {
        public static IResult Execute(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return new ErrorResult(logic.Message);
                }
            }

            return new SuccessResult();
        }
    }
}