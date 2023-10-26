using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Model
{
    public class Stock:BaseModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public Store Store { get; set; } //one to one relation
    }
}
