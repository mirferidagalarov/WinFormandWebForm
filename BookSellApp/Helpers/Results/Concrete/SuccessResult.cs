﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Helpers.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(message, true)
        {
        }
    }
}