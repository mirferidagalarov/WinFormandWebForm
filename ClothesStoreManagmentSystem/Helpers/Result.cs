using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Helpers
{
    public class Result
    {
        public Result(string message, bool isSucces)
        {
            Message = message;
            IsSucces = isSucces;
        }

        public string Message { get;}
        public bool IsSucces { get;}  

    }
}
