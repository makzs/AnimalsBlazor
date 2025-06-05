namespace AnimalsBlazor.Services;

public interface IAnimalService
{
    Task<string?> GetRandomDogImageAsync();
}
