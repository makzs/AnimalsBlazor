namespace AnimalsBlazor.Services;

public interface IAnimalService
{
    Task<string?> GetRandomDogImageAsync();
    Task<string?> GetRandomDuckImageAsync();
    Task<string?> GetRandomFoxImageAsync();
}
