namespace Pokemon.Class;

public class PokemonDTO
{
    public int id {get; set;}
    public string Nombre {get; set;}
    public string Tipo {get; set;}
    public IEnumerable<int> Habilidades {get; set;}
    public float Defensa {get; set;}
}