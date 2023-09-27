using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ListinhaDeCompras
{
    public class Produto
    {
        //Atributos
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto( string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double CalcularTotal()
        {
            return Quantidade * Preco;
        }
    }
}
