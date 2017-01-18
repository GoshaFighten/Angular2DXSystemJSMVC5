using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2DXSystemJSMVC5.Models {
    public class Order {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
    }
}