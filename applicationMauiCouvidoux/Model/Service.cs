using System.Diagnostics;
using System.Text.Json;
using Microsoft.VisualBasic;


namespace applicationMauiCouvidoux.Model;

public class Service
{
    
    HttpClient _client;
    JsonSerializerOptions _serializerOptions;

    public List<Monster> Items { get; private set; }

    public Service()
    {
        _client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
    }
    
    public async Task<List<Monster>> RefreshDataAsync()
    {
        var Items = new List<Monster>();

        Uri uri = new Uri("https://api.sampleapis.com/monstersanctuary/monsters");
        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<Monster>>(content, _serializerOptions);
            }
        }
        catch (Exception ex)
        {
            //Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }

        return Items;
    }
}