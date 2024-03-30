using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.View;

public partial class PageApiAjout : ContentPage
{
    public PageApiAjout()
    {
        InitializeComponent();
        var pageApiAjoutVIewModel = new PageApiAjoutVIewModel();
        BindingContext = pageApiAjoutVIewModel;
    }
}