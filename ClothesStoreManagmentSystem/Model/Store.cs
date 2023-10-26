using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Model
{
    public class Store : BaseModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string WebAdress { get; set; }

        public Stock  Stock { get; set; } //one to one relation

    }
}
