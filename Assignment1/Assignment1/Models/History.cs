using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class History
    {
        public string name { get; set; } 
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        public DateTime purchaseDate { get; set; }

        public History(string nm, int qt, double tp, DateTime pd)
        {
            name = nm;
            quantity = qt;
            totalPrice = tp;
            purchaseDate = pd;
        }
    }
}
