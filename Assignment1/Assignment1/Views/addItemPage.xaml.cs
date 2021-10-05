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
    public partial class addItemPage : ContentPage
    {
        public ObservableCollection<Item> items;
        public addItemPage(ObservableCollection<Item> its)
        {
            InitializeComponent();
            items = its;
        }

        private void save_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nm.Text) || string.IsNullOrEmpty(pr.Text) || string.IsNullOrEmpty(qt.Text))
            {
                DisplayAlert("Error", "Fields Are Not Entered Correctly", "OK");
            }
            else
            {
                items.Add(new Item(nm.Text, Int32.Parse(qt.Text), Double.Parse(pr.Text)));
                Navigation.PopAsync();
                DisplayAlert("Done!", "New Product Added Sucessfully", "OK");
            }
        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}