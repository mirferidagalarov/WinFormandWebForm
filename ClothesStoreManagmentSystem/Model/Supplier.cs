using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Model
{
    public class Supplier:Human
    {
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string BankNumber { get; set; }
        public List<Product> Products { get; set; } //one to many relation
    }
}
