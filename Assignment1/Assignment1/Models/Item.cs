using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment1
{
    public class Item : INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged = delegate { };

        private string Name;
        public string name 
        {
            get { return Name; }
            set
            {
                Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("name"));
            }
        }

        private int Quantity;
        public int quantity 
        {
            get { return Quantity; }
            set
            {
                Quantity = value;
                PropertyChanged(this, new PropertyChangedEventArgs("quantity"));
            }
        }
        
        private double Price;
        public double price 
        {
            get { return Price; }
            set
            {
                Price = value;
                PropertyChanged(this, new PropertyChangedEventArgs("price"));
            }
        }

        public Item()
        {

        }

        public Item( string nm, int qty, double pr)
        {
            name = nm;
            quantity = qty;
            price = pr;
        }
    }
}
