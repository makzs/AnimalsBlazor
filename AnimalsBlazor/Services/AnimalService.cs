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
}

