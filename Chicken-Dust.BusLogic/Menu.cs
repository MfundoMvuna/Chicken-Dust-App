using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Dust.BusLogic
{
    internal class Menu
    {
        private int menuID;
        private string productName;
        private string description;
        private string sauce;
        private decimal price;
        private int quantity;

        public int MenuID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Sauce { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
