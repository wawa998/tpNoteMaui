using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.View;

public partial class PageApiAjout : ContentPage
{
    private PageApiAjoutVIewModel pageApiAjoutVIewModel;
    public PageApiAjout()
    {
        InitializeComponent();
        pageApiAjoutVIewModel = new PageApiAjoutVIewModel();
        
        BindingContext = pageApiAjoutVIewModel;
    }

    private void InputView_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
            pageApiAjoutVIewModel.Name = e.NewTextValue;
    }

    private void InputView_OnTextChanged_strenght(object? sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == "" || !char.IsDigit(e.NewTextValue[0]))
        {
            pageApiAjoutVIewModel.Strenght = -1;
        }
        else
        {
            pageApiAjoutVIewModel.Strenght = int.Parse(e.NewTextValue);
        }
    }

    private void InputView_OnTextChanged_Magic(object? sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == "" || !char.IsDigit(e.NewTextValue[0]))
        {
            pageApiAjoutVIewModel.Magic = -1;
        }
        else
        {
            pageApiAjoutVIewModel.Magic = int.Parse(e.NewTextValue);
        }
        
    }

    private void InputView_OnTextChanged_health(object? sender, TextChangedEventArgs e)
    {
       
        if (e.NewTextValue == "" || !char.IsDigit(e.NewTextValue[0]))
        {
            pageApiAjoutVIewModel.Health = -1;
        }
        else
        {
            pageApiAjoutVIewModel.Health = int.Parse(e.NewTextValue);
        }
        
    }

    private void InputView_OnTextChanged_defense(object? sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == "" || !char.IsDigit(e.NewTextValue[0]))
        {
            pageApiAjoutVIewModel.Defense = -1;
        }
        else
        {
            pageApiAjoutVIewModel.Defense = int.Parse(e.NewTextValue);
        }
    }

    private void InputView_OnTextChanged_potion(object? sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == "" || !char.IsDigit(e.NewTextValue[0]))
        {
            pageApiAjoutVIewModel.Potion = -1;
        }
        else
        {
            pageApiAjoutVIewModel.Potion = int.Parse(e.NewTextValue);
        }
        
    }
}