using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Shipments;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Payments
{
     class Payment : ShipmentOrder
    {
        public Driver uname;
        private string paymentmode;
        private string amount;
    }
}
