namespace Pokemon.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        Pokemon Pokemon = new Pokemon();

        app.MapPost("/api/v1/add", (PokemonDTO pokemon) =>
        {
            Pokemon.Add(pokemon);
        });

        app.MapPut("/api/v1/actualizar/{id}", (int id, PokemonDTO pokemon) =>
        {
            Pokemon.Update(id, pokemon);
        });

        app.MapGet("/api/v1/{id}", (int id) =>
        {
            return Results.Ok(Pokemon.GetId(id));
        });

        app.MapGet("/api/v1/{tipo}", (string Tipo) =>
        {
            return Results.Ok(Pokemon.ListaPorTipo(Tipo));
        });

        app.MapPost("/api/v1/addmuchos", (PokemonDTO[] pokemonDTO) =>
        {
            for (int x = 0; x <= pokemonDTO.Length - 1; x++)
            {
                Pokemon.Add(pokemonDTO[x]);
            }
        });

        app.MapDelete("/api/v1/delete/{id}", (int id) =>
        {
            Pokemon.Delete(id);
        });

        app.MapGet("/api/v1/taller/listanombre", () =>
        {
            return Results.Ok(Pokemon.ListaPorNombre());
        });

         app.MapGet("/api/v1/taller/listanombredescendente", () =>
        {
            return Results.Ok(Pokemon.ListaPorNombreDescendente());
        });

        app.Run();
    }
}
