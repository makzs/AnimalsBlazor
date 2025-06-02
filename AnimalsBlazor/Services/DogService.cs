using AnimalsBlazor.Models;

namespace AnimalsBlazor.Services;

public class DogService : IDogService
{

    private readonly HttpClient _httpClient;

    public DogService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> GetRandomDogImageAsync()
    {
        var resposne = await _httpClient.GetFromJsonAsync<DogApiResponse>("https://dog.ceo/api/breeds/image/random");
        return resposne?.Message;
    }
}

