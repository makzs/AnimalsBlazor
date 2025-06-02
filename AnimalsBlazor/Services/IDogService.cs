namespace AnimalsBlazor.Services;

public interface IDogService
{
    Task<string?> GetRandomDogImageAsync();
}
