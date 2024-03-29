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
    
    public PageApiVisuel()
    {
        InitializeComponent();
        var pageApiVisuelViewModel = new PageApiVisuelViewModel();
        BindingContext = pageApiVisuelViewModel;
        
    }
    
}



