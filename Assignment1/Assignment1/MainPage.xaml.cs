using Assignment1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//test

namespace Assignment1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> items;
        public List<History> history;
        public int i;
        
        public MainPage()
        {
            InitializeComponent();
            
            items = new ObservableCollection<Item>
            {
                new Item( "Pants", 20, 89.99),
                new Item("Shoes", 50, 109.99),
                new Item("Hats", 10, 34.99),
                new Item("Tshirts", 10, 19.99),
                new Item("Dresses", 24, 89.99)
            };
            history = new List<History>();
            inventory.ItemsSource = items;
            productName.Text = "Type";
            i = -1;
                      
        }

        private void inventory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            productName.Text = (e.SelectedItem as Item).name;
            quantity.Text = "Quantity";
            i = items.IndexOf((e.SelectedItem as Item));
            total.Text = "Total";
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i == -1)
            {
                DisplayAlert("Error", "Please Select An Item", "OK");
            }
            else {
                if (quantity.Text.Equals("Quantity"))
                {
                    quantity.Text = (sender as Button).Text;
                }
                else
                {
                    quantity.Text += (sender as Button).Text;
                }
                total.Text = (items[i].price * Int32.Parse(quantity.Text)).ToString("0.00");
            }
        }

        private void Buy_Clicked(object sender, EventArgs e)
        {
            if (i == -1)
            {
                DisplayAlert("Error", "Please Select An Item", "OK");
            }
            else if (Int32.Parse(quantity.Text) > items[i].quantity)
            {
                DisplayAlert("Error", "Not Enough Inventory To Make Purchase", "OK");
                quantity.Text = "Quantity";
                total.Text = "Total";
            }
            else
            {
                history.Add(new History(items[i].name, Int32.Parse(quantity.Text), Double.Parse(total.Text), DateTime.Now));
                items[i].quantity -= Int32.Parse(quantity.Text);
                i = -1;
                quantity.Text = "Quantity";
                total.Text = "Total";
                productName.Text = "Type";
                
            }
        }

        private void Manager_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new managerPage(history, items));

        }
    }
}
