using ClothesStoreManagmentSystem.Helpers;
using ClothesStoreManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Operations
{
    public interface IBaseOperation<T> where T :BaseModel,new()
    {
        Result Add(T model);
        Result Delete(T model);
        Result Update(T model);
        T Get(int id);
        List<T> GetAll();

        int GetNextId();

    }
}
