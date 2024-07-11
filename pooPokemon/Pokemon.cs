using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{

    public class Pokemon
    {
        public Pokemon()
        {

        }

        private string nome;

        public string Nome
        {
            get { return this.nome; }
            set
            {
                string texto = value.ToUpper();
                this.nome = texto;
            }
        }

        private string descricao;//Armazena o valor da propriedade Descricao;

        public string Descricao//Representa a caracteristica Descricao do meu pokemon;
        {
            get { return descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine($"Descrição do Pokemon: {this.Descricao} ");
        }

    }
}
