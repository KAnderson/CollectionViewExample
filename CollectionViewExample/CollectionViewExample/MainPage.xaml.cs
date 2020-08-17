using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewExample
{
    public partial class MainPage : ContentPage
    {
        MainViewModel vm = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.InitializeAsync();
        }
    }
}
