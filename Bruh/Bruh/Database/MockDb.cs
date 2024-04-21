using Bruh.Models;

namespace Bruh.Database;

public class MockDb
{
    public List<Animal> Animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };
}