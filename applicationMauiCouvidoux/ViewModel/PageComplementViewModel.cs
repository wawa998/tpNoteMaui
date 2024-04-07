using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using applicationMauiCouvidoux.Model;

namespace applicationMauiCouvidoux.ViewModel;

public class PageComplementViewModel: INotifyPropertyChanged
{
    private String _message;
    
    public ICommand TapToLink => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public String Message
    {
        get { return _message;}
        set
        {
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }
    
    private readonly DateTime stalkerRealeaseDate;
    
    public PageComplementViewModel()
    {
        stalkerRealeaseDate = new DateTime(2024, 9, 5); // Prochain changement à minuit
        UpdateCountdown();
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            UpdateCountdown();
            return true;
        });
    }
    
    private void UpdateCountdown()
    {
        TimeSpan timeUntilChange = stalkerRealeaseDate - DateTime.Now;
        Message = $"Time until realease \nDays : {timeUntilChange.Days:D2}\nHours : {timeUntilChange.Hours:D2}\nMinutes : {timeUntilChange.Minutes:D2}\nSeconds : {timeUntilChange.Seconds:D2}";
    }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}