using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Produto
    {
        // Propriedades automáticas
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Disponivel { get; set; }

        // Construtor com parâmetros
        public Produto(string nome, string categoria, double preco, int quantidade, bool disponivel)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
            Disponivel = disponivel;
        }

        // Método para calcular o valor total em stock
        public double CalcularValorTotal()
        {
            return Preco * Quantidade;
        }

        // Método de apresentação dos dados
        public string ExibirProduto()
        {
            string estado = Disponivel ? "Disponível" : "Indisponível";

            return $"Nome: {Nome}\n" +
                   $"Categoria: {Categoria}\n" +
                   $"Preço: {Preco:C}\n" +
                   $"Quantidade: {Quantidade}\n" +
                   $"Estado: {estado}\n" +
                   $"Valor Total em Stock: {CalcularValorTotal():C}";
        }

    }
}
