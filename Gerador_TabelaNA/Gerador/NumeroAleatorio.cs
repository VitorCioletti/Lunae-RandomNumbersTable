namespace Gerador_TabelaNA
{
    using System.Security.Cryptography;
    using System.Text;

    public static class NumeroAleatorio
    {
        public static StringBuilder GerarNovo() =>
            ParticionaNumeroAleatorio(BigInteger.genPseudoPrime(201, 1, new RNGCryptoServiceProvider()).ToString());

        private static StringBuilder ParticionaNumeroAleatorio(string numero)
        {
            numero = numero.Substring(1);

            var pontoInicialParticao = 0;
            var qtdaParticoes = numero.Length / 5;
            var numeroParticionado = new StringBuilder();

            for (int i = 0; i < qtdaParticoes; i++)
            {
                numeroParticionado.Append(numero.Substring(startIndex: pontoInicialParticao, length: 5));
                numeroParticionado.Append("  ");

                pontoInicialParticao += 5;
            }

            return numeroParticionado;
        }
    }
}