namespace pooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = ("bulbasaulro");
            p.Descricao = ("O bulbasauro é um pokemon do tipo planta");
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
