using ClothesStoreManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Operations
{
    public interface IStoreOperation:IBaseOperation<Store>
    {
        void CheckedStoreExistance();

    }
}
