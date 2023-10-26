using BookSellApp.Helpers.Results.Abstract;
using BookSellApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.DynamicData;

namespace BookSellApp.Operation.Abstract
{
    public interface IBaseOperation<T> where T : IModel, new()
    {
        IResult Add(T model);
        IResult Remove(T model);
        IResult Update(T model);
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IDataResult<int> GetNextId();

    }
}
