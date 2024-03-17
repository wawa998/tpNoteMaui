using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.View;

public partial class PageApiVisuel : ContentPage
{
    private  List<ApiItems> items;
    public PageApiVisuel()
    {
        InitializeComponent();
        items = new List<ApiItems>
        {
            new ApiItems{Title = "Shadow of chernobyl" , Src = "../resources/images/stalkers.jpg", visible = false},
            new ApiItems{Title = "Clear Sky" , Src = "../resources/images/stalkercs.jpg", visible = false},
            new ApiItems{Title = "Call of pripyat" , Src = "../resources/images/stalkerc.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
            new ApiItems{Title = "Heart of chernobyl" , Src = "../resources/images/stalkerd.jpg", visible = false},
        };

        apiView.ItemsSource = items;
    }
    
    private void ApiView_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        var items2 = new List<ApiItems>(items);
        {
            foreach (var apiItems in items2)
            {
                apiItems.visible = false;
            }
        }
        
        items2[e.SelectedItemIndex].visible=true;
        apiView.ItemsSource = items2;
        items.Clear();
        items = items2;
    }
    

}