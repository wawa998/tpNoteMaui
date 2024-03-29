using System.Collections.ObjectModel;
using System.ComponentModel;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class PageApiVisuelViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Monster> _monsters;

    public ObservableCollection<Monster> Monsters
    {
        get { return _monsters;}
        set
        {
            _monsters = value;
            OnPropertyChanged(nameof(Monsters));
        }
    }
    
    
    public PageApiVisuelViewModel()
    {
        Monsters = appData.list;
    }
    

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}