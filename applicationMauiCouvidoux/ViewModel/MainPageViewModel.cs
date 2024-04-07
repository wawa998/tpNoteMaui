using System.ComponentModel;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class MainPageViewModel : INotifyPropertyChanged
{
    private List<carouselItem> _carousselItems;

    public List<carouselItem> CarouselItems
    {
        get { return _carousselItems;}
        set
        {
            _carousselItems = value;
            OnPropertyChanged(nameof(CarouselItems));
        }
    }
    
    
    public MainPageViewModel()
    {
        CarouselItems = new List<carouselItem>(){
            new carouselItem{Title = "Shadow of chernobyl" , Src = "stalkers.jpg"},
            new carouselItem{Title = "Clear Sky" , Src = "stalkercs.jpg"},
            new carouselItem{Title = "Call of pripyat" , Src = "stalkerc.jpg"},
            new carouselItem{Title = "Heart of chernobyl" , Src = "stalkerd.jpg"}
        };
    }
    

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}