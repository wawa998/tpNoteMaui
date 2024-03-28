using System.Diagnostics;
using applicationMauiCouvidoux.Model;
using applicationMauiCouvidoux.View;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var mainViewModel = new MainPageViewModel();
            BindingContext = mainViewModel;

        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new GifPage());
        }
    }

}
