using System.ComponentModel;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class descriptionPageViewModel: INotifyPropertyChanged
{
    private Monster _monster;

    public Monster Monster
    {
        get { return _monster;}
        set
        {
            _monster = value;
            OnPropertyChanged(nameof(Monster));
        }
    }
    
    
    public descriptionPageViewModel(int i )
    {
        Monster = appData.list[i];
    }
    

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}