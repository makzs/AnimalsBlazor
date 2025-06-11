using AnimalsBlazor.Models;

namespace AnimalsBlazor.Services;

public class AnimalService : IAnimalService
{

    private readonly HttpClient _httpClient;

    public AnimalService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> GetRandomDogImageAsync()
    {
        var resposne = await _httpClient.GetFromJsonAsync<DogApiResponse>("https://dog.ceo/api/breeds/image/random");
        return resposne?.Message;
    }

    public async Task<string?> GetRandomDuckImageAsync()
    {
        var resposne = await _httpClient.GetFromJsonAsync<DuckApiResponse>("https://random-d.uk/api/v2/random");
        return resposne?.Url;
    }

    public async Task<string?> GetRandomFoxImageAsync()
    {
        var resposne = await _httpClient.GetFromJsonAsync<FoxApiResponse>("https://randomfox.ca/floof/");
        return resposne?.Image;
    }
}

