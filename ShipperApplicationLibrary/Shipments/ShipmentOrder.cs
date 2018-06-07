using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Shipments
{
    class ShipmentOrder : Shipper
    {
        public Driver dr;
        private string From_adress;
        private string To_adress;
        private string Dimensions;
        private string Weight;
    }
}
