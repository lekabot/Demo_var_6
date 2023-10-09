﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_var_6.Classes.DataBaseClasses
{
    class Orders
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PickupPointID { get; set; }
        public int UserID { get; set; }
        public int ReceivingCode { get; set; }
        public string Status { get; set; }
    }
}
