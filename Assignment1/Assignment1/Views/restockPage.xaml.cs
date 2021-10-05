using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class restockPage : ContentPage
    {
        public ObservableCollection<Item> items;
        public int itemIndex; 
        public restockPage(ObservableCollection<Item> i)
        {
            InitializeComponent();
            items = i;
            its.ItemsSource = items;
            itemIndex = -1;

        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void its_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            itemIndex = items.IndexOf((e.SelectedItem as Item));
        }

        private void restock_Clicked(object sender, EventArgs e)
        {
            if(itemIndex == -1)
            {
                DisplayAlert("Error", "You have to select an item and provide a new quantity", "OK");
            }
            else if(string.IsNullOrEmpty(addQTY.Text))
            {
                DisplayAlert("Error", "You have to select an item and provide a new quantity", "OK");
            }
            else
            {
                items[itemIndex].quantity += Int32.Parse(addQTY.Text);
                itemIndex = -1;
                addQTY.Text = "";
                its.SelectedItem = false;
                
            }

        }
    }
}