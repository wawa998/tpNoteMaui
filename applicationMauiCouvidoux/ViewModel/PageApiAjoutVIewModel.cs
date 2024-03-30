using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class PageApiAjoutVIewModel : INotifyPropertyChanged
{

    public ICommand AjoutItemApi { get; }
    
    public PageApiAjoutVIewModel()
    {
        AjoutItemApi = new Command(AjoutItem);
    }

    private void AjoutItem()
    {
        appData.addList(new Monster
        {
            Name = "monster test",
            Image = "../resources/images/stalkers.jpg",
            Stats = new Stats
            {
                Strength = 5,
                Defence = 5,
                Health = 5,
                Magic = 5,
                Potion = 5
            },
            Elements = null,
            Resistance = null,
            Weakness = null,
            Id = 0,
        });
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}