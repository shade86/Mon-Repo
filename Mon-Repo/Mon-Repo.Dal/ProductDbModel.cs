﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo.Dal
{
    public class ProductDbModel
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
