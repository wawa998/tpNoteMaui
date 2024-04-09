using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.View;

public partial class DescriptionPage : ContentPage
{
    public DescriptionPage(int i)
    {
        InitializeComponent();
        var desc = new DescriptionPageViewModel(i);
        BindingContext = desc;
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_OnClickedDelete(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}