using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class PageApiAjoutVIewModel : INotifyPropertyChanged
{
    private String _name;
    
    public String Name
    {
        get { return _name;}
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
    private int  _strenght;
    
    public int Strenght
    {
        get { return _strenght;}
        set
        {
            _strenght = value;
            OnPropertyChanged(nameof(Strenght));
        }
    }
    
    private int  _magic;
    
    public int Magic
    {
        get { return _magic;}
        set
        {
            _magic = value;
            OnPropertyChanged(nameof(Magic));
        }
    }
    
    private int  _health;
    
    public int Health
    {
        get { return _health;}
        set
        {
            _health = value;
            OnPropertyChanged(nameof(Health));
        }
    }

    private int _defense;
    
    public int Defense
    {
        get { return _defense;}
        set
        {
            _defense = value;
            OnPropertyChanged(nameof(Defense));
        }
    }
    
    private int _potion;
    
    public int Potion
    {
        get { return _potion;}
        set
        {
            _potion = value;

            OnPropertyChanged(nameof(Potion));
        }
    }
    
    private String _source;
    
    public String Source
    {
        get { return _source;}
        set
        {
            _source = value;

            OnPropertyChanged(nameof(Source));
        }
    }
    
    public ICommand AjoutItemApi { get; }
    
    public ICommand ImagePicker { get; }
    
    public PageApiAjoutVIewModel()
    {
        AjoutItemApi = new Command(AjoutItem);
        ImagePicker = new Command(TakePhoto);
        Strenght = -1;
        Health = -1;
        Defense = -1;
        Magic = -1;
        Potion = -1;
        Name = "";
        Source = "";

    }

    public async void TakePhoto()
    {
            FileResult photo = await MediaPicker.Default.PickPhotoAsync();

            if (photo != null)
            {
                // save the file into local storage
                Source = photo.FullPath;

            }
        
    }
    
    private void AjoutItem()
    {
        if (Name.Length != 0 && Source.Length != 0 && Strenght != -1 && Magic != -1 && Health != -1 && Defense != -1 && Potion != -1)
        {
            appData.addList(new Monster
            {
                Name = Name,
                Image = Source,
                Stats = new Stats
                {
                    Strength = Strenght,
                    Defence = Defense,
                    Health = Health,
                    Magic = Magic,
                    Potion = Potion
                },
                Elements = null,
                Resistance = null,
                Weakness = null,
                Id = 0,
            });
        }
        
        
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}