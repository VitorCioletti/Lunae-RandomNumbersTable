namespace TableGenerator
{
    using System.Security.Cryptography;
    using System.Text;

    public static class RandomNumber
    {
        public static StringBuilder GenerateNew() =>
            SeparateRandomNumber(BigInteger.genPseudoPrime(201, 1, new RNGCryptoServiceProvider()).ToString());

        private static StringBuilder SeparateRandomNumber(string number)
        {
            number = number.Substring(1);

            var startPoint = 0;
            var qtdaParticoes = number.Length / 5;
            var resultedNumber = new StringBuilder();

            for (int i = 0; i < qtdaParticoes; i++)
            {
                resultedNumber.Append(number.Substring(startIndex: startPoint, length: 5));
                resultedNumber.Append("  ");

                startPoint += 5;
            }

            return resultedNumber;
        }
    }
}