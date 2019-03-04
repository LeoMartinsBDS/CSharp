using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        //atributo private segue esse padrao
        private string _nome;

        public double Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto()
        {
            QuantidadeEstoque = 10;
        }
        //SOBRECARGA
        //this utilizado para referenciar o construtor
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtd) : this(nome, preco)
        {
            QuantidadeEstoque = qtd;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public double ValorTotalEstoque()
        {
            return Preco * QuantidadeEstoque;
        }

        public void AdicionarProdutoEstoque(int qtdDigitada)
        {
            QuantidadeEstoque += qtdDigitada;
        }

        public void RemoverProdutoEstoque(int qtdDigitada)
        {
            QuantidadeEstoque -= qtdDigitada;
        }


        public override string ToString()
        {
            return _nome
                   + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", " + QuantidadeEstoque + " unidades, Total: R$"
                   + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
