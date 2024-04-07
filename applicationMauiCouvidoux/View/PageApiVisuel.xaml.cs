using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using applicationMauiCouvidoux.Model;
using System;
using System.Collections.Generic;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.View;

public partial class PageApiVisuel : ContentPage
{
    public PageApiVisuelViewModel pageApiVisuelViewModel;
    public PageApiVisuel()
    {
        InitializeComponent();
        
        pageApiVisuelViewModel = new PageApiVisuelViewModel();
        
        BindingContext = pageApiVisuelViewModel;
        
    }

    private void ListView_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        Navigation.PushAsync(new  descriptionPage(e.SelectedItemIndex));
    }
}



