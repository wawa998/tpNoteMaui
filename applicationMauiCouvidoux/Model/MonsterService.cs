using System.Collections.ObjectModel;

namespace applicationMauiCouvidoux.Model;

public class MonsterService
{
    private static Service _service = new Service();
    
    
    public static async Task<ObservableCollection<Monster>> LoadData()
    {
        return await _service.RefreshDataAsync();
        
    }
}