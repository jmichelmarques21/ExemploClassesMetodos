using System;
using System.Globalization;

namespace ExemploClassesMetodos {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public int AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
            return Quantidade;
        }

        public int RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
            return Quantidade;
        }

        public override string ToString() {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades. " +
                "Valor total em estoque: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
