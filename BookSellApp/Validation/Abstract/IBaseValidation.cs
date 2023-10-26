using BookSellApp.Helpers.Results.Abstract;
using BookSellApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellApp.Validation.Abstract
{
    public interface IBaseValidation<T> where T : IModel,new()
    {
        IValidationResult Validate(T model);    
    }
}
