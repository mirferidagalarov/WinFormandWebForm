using BookSellApp.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Helpers.DB
{
    public class BookAppDB
    {
        public static List<User> Users { get; set; }
        public BookAppDB()
        {
            Users=new List<User>();
        }
    }
}