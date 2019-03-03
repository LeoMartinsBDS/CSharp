using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

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
            return Nome
                   + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", " + QuantidadeEstoque + " unidades, Total: R$"
                   + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
