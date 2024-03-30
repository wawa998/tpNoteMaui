using System.Collections.ObjectModel;
using applicationMauiCouvidoux.View;
using applicationMauiCouvidoux.ViewModel;

namespace applicationMauiCouvidoux.Model;

public class appData
{
    public static ObservableCollection<Monster> list = new ObservableCollection<Monster>();

    public static void addList(Monster monster)
    {
        list.Add(monster);
        //PageApiVisuelViewModel.instance.listofMonster = list;
    }
    
}