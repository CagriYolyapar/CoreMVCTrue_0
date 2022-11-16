﻿using System.Collections.Generic;

namespace CoreMVCTrue_0.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int? AppUserID { get; set; }


        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
