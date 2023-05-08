namespace Pokemon.Class;

using System.Collections.Generic;
public class Pokemon : IPokemon
{
    private List<PokemonDTO> BD;
    public Pokemon()
    {
        this.BD = new List<PokemonDTO>();
    }
    public void Add(PokemonDTO pokemon)
    {
        this.BD.Add(pokemon);
    }
    public void Delete(int id)
    {
        this.BD.RemoveAll(pokemon => pokemon.id == id);
    }
    public void Update(int id, PokemonDTO pokemon)
    {
        PokemonDTO pokemonUpdate = this.BD.Single((pokemon => pokemon.id == id));
        pokemonUpdate.Nombre = pokemon.Nombre;
        pokemonUpdate.Tipo = pokemon.Tipo;
        pokemonUpdate.Defensa = pokemon.Defensa;
    }
    public PokemonDTO GetId(int id)
    {
        return this.BD.Single(pokemon => pokemon.id == id);
    }
    public IEnumerable<PokemonDTO> ListaPorTipo(String Tipo)
    {
        return this.BD.Where(pokemon => pokemon.Tipo == Tipo);
    }
    public IEnumerable<PokemonDTO> ListaPorNombre()
    {
        return this.BD.OrderBy(pokemon => pokemon.Nombre);
    }
    public IEnumerable<PokemonDTO> ListaPorNombreDescendente()
    {
        return this.BD.OrderByDescending(pokemon => pokemon.Nombre);
    }
    bool IPokemon.Add(PokemonDTO poke)
    {
        throw new NotImplementedException();
    }

    bool IPokemon.Delete(int id)
    {
        throw new NotImplementedException();
    }

    bool IPokemon.Update(int id, PokemonDTO updatedPoke)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PokemonDTO> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<PokemonDTO> GetALL()
    {
        throw new NotImplementedException();
    }
}