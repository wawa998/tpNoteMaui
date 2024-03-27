using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using applicationMauiCouvidoux.Model;
using System;
using System.Collections.Generic;
namespace applicationMauiCouvidoux.View;

public partial class PageApiAjout : ContentPage
{
    

    public List<Monster> Items;
    public Service service;
    public PageApiAjout()
    {
        InitializeComponent();
        service = new Service();
        List<Monster> MonsterItems = new List<Monster>
        {
            new Monster
            {
                Id = 1,Image = "haha", Name = "bhbh",
                Elements = null,
                Weakness = null,
                Resistance = null,
                Stats = null
            },
            new Monster
            {
                Id = 2, Image = "xdgxfg", Name = "dssdxfxxxxxg",
                Elements = null,
                Weakness = null,
                Resistance = null,
                Stats = null
            }
        };

        List<items> imtems2 = new List<items>
        {
            new items{Image = "test", Name = "testeur"}
        };
        
        
        
        LoadData();
    }
    
    private async void LoadData()
    {
        List<Monster> lits2;
        lits2 = await service.RefreshDataAsync();
        // Vous pouvez utiliser Newtonsoft.Json pour désérialiser votre objet JSON en une instance de la classe Monster
        string json = @"{
            ""id"": 1,
            ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/6/62/Spectral_Wolf.png/revision/latest/scale-to-width-down/50?cb=20201204141949"",
            ""name"": ""Spectral Wolf"",
            ""elements"": [
              {
                ""type"": ""Water (Element)"",
                ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/6/65/Icon_Water.png/revision/latest/scale-to-width-down/20?cb=20190401052121""
              },
              {
                ""type"": ""Wind (Element)"",
                ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/a/a7/Icon_Wind.png/revision/latest/scale-to-width-down/20?cb=20190401052123""
              },
              {
                ""type"": ""Neutral (Element)"",
                ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/6/61/Icon_Neutral.png/revision/latest/scale-to-width-down/20?cb=20190428162508""
              }
            ],
            ""weakness"": [
              {
                ""type"": ""Earth Weakness"",
                ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/3/3d/Icon_weakness_earth.png/revision/latest/scale-to-width-down/25?cb=20190404223118""
              }
            ],
            ""resistance"": [
              {
                ""type"": ""Wind Resistance"",
                ""image"": ""https://static.wikia.nocookie.net/monster-sanctuary/images/3/38/Icon_wind_resistance.png/revision/latest/scale-to-width-down/25?cb=20190428155732""
              }
            ],
            ""stats"": {
              ""strength"": 5,
              ""magic"": 5,
              ""health"": 7,
              ""defence"": 4,
              ""potion"": 8
            }
          }";
        try
        {
            
            apiView2.ItemsSource = lits2;
        }
        catch (Exception e)
        {
            List<items> imtems3 = new List<items>
            {
                new items{Image = "erreur", Name = e.Message }
            };

            apiView2.ItemsSource = imtems3;
        }
        /*
        try
        {
            HttpResponseMessage response = await _client.GetAsync("https://api.sampleapis.com/monstersanctuary/monsters");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<Monster>>(content, _serializerOptions);
                apiView.ItemsSource = Items;
            }
        }
        catch (Exception ex)
        {

    *          Items.Add(new Monster
            {
                id = 1, image = "haha", name = "bhbh", elements = new types { type = "haha", images = "bhbh" },
                weakness = new types { type = "haha", images = "bhbh" },
                resistance = new types { type = "haha", images = "bhbh" },
                stats = new Stats { defence = 2, health = 2, magic = 2, potion = 2, strength = 2 }
            });
            apiView.ItemsSource = Items;

        } */
    }

}

public class items
{
    public string Image { get; set; }
    public string Name { get; set; }
}

