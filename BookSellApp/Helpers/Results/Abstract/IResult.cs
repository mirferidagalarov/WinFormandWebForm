﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellApp.Helpers.Results.Abstract
{
    public interface IResult
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}
