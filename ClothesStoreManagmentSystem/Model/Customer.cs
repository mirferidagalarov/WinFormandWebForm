using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Model
{
    public class Customer:Human
    {
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public byte DiscountPercent { get; set; }



    }
}
