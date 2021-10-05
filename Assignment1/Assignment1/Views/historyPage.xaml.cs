using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class historyPage : ContentPage
    {
        public List<History> history;
        public historyPage(List<History> hs)
        {
            InitializeComponent();
            history = hs;
            histy.ItemsSource = history;
        }

        private void hist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new histDetails(e.SelectedItem as History));
        }
    }
}