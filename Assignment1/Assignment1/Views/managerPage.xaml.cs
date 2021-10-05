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
    public partial class managerPage : ContentPage
    {
        public List<History> history;
        public ObservableCollection<Item> items;
        public managerPage( List<History> hs , ObservableCollection<Item> i)
        {
            InitializeComponent();
            history = hs;
            items = i;
        }

        private void History_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new historyPage( history));
        }

        private void Restock_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new restockPage(items));
        }
        private void AddItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addItemPage(items));
        }

    }
}