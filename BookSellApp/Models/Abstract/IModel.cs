﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellApp.Models
{
    public interface IModel
    {
         int ID { get; set; }
        DateTime LastUpdateDate { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
