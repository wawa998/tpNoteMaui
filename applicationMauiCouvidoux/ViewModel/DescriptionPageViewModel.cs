using System.ComponentModel;
using System.Windows.Input;
using applicationMauiCouvidoux.Model;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace applicationMauiCouvidoux.ViewModel;

public class DescriptionPageViewModel: INotifyPropertyChanged
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
    
    public ICommand deleteItem { get; }
    private int index;
    private void DeleteItem()
    {
        appData.list.RemoveAt(index);
        showToast("Monster deleted");
    }
    public DescriptionPageViewModel(int i )
    {
        index = i;
        Monster = appData.list[index];
        deleteItem = new Command(DeleteItem);
    }
    
    private async void showToast(String text)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show(cancellationTokenSource.Token);
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}