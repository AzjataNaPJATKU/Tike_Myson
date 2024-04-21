using Bruh.Database;
using Bruh.Models;

namespace Bruh.endPoints;

public static class AnimalEndPoints
{
    public static void MapAnimalEndPoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - ok
            // 400 - Bad Request
            // 404 - Not Found
            var animals = StaticData.animals;
            return Results.Ok(animals);
        });
        app.MapGet("/animals/{id}", (int id) =>
        {
    
            return Results.Ok(id);
        });
        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("",animal);
        });

    }
}