using System.Diagnostics;
using applicationMauiCouvidoux.Model;
using applicationMauiCouvidoux.View;

namespace applicationMauiCouvidoux
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
            var items = new List<CollectionItem>
            {
                new CollectionItem{Title = "Shadow of chernobyl" , Src = "../resources/images/stalkers.jpg"},
                new CollectionItem{Title = "Clear Sky" , Src = "../resources/images/stalkercs.jpg"},
                new CollectionItem{Title = "Call of pripyat" , Src = "../resources/images/stalkerc.jpg"},
                new CollectionItem{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg"},
            };

            CarouselView.ItemsSource = items;
            
            
        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new GifPage());
        }
    }

}
