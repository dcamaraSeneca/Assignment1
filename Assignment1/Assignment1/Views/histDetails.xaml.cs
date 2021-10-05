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
    public partial class histDetails : ContentPage
    {
        
        public histDetails(History hi)
        {
            InitializeComponent();
            
            nm.Text = hi.name;
            qt.Text = hi.quantity.ToString();
            dt.Text = hi.purchaseDate.ToString();
            ta.Text = "Total amount: " + hi.totalPrice.ToString("0.00");
            title.Title = hi.name;
        }
    }
}