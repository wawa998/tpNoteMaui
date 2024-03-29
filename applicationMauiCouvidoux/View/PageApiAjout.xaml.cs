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

public partial class PageApiAjout : ContentPage
{
    
    public PageApiAjout()
    {
        InitializeComponent();
        var pageApiVisuelViewModel = new PageApiVisuelViewModel();
        BindingContext = pageApiVisuelViewModel;
        
    }
    
}



