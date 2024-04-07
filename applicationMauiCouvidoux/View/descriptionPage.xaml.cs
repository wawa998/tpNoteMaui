using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.View;

public partial class descriptionPage : ContentPage
{
    public descriptionPage(int i)
    {
        InitializeComponent();
        var desc = new descriptionPageViewModel(i);
        BindingContext = desc;
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}