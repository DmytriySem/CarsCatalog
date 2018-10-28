﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Cost
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
