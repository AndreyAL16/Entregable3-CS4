namespace Pokemon.Class;

public interface IPokemon
{
    bool Add(PokemonDTO poke);
    bool Delete(int id);
    bool Update(int id, PokemonDTO updatePoke);
    List<PokemonDTO> GetALL();
}

