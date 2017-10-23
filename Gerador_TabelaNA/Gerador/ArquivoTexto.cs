namespace Gerador_TabelaNA
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Text;

    public static class ArquivoTexto
    {
        public static void  CriaPDF(string nomeUniversidade, string nomeTabela, string nomeProfessor, string nomeCurso, int periodo, string caminhoSalvar)
        {
            var documento = CriaArquivoSalvo(caminhoSalvar);

            documento.Open();

            var tituloUniversidade = new Paragraph(nomeUniversidade);
            tituloUniversidade.Alignment = Element.ALIGN_CENTER;
            
            documento.Add(tituloUniversidade);
            documento.Add(new Paragraph($"Professor: { nomeProfessor}"));
            documento.Add(new Paragraph($"Tipo: {nomeTabela}"));

            documento.Add(new Paragraph($"Curso: {nomeCurso} - {periodo}º período"));
            documento.Add(new Paragraph(" "));
            
            for (int i = 0; i <= 34; i++)
            {
                var randomico = GeraNumeroAleatorio();

                Paragraph linha = new Paragraph($"{i.ToString()}      {randomico}");
                linha.Alignment = Element.ALIGN_CENTER;
                
                documento.Add(linha);
            }

            AdicionaMetaDados(documento);

            documento.Add(new Paragraph(" "));

            var versaoRodape = new Paragraph($"Feito por: Vitor Cioletti Morais [Lunae {ConfigurationManager.AppSettings["versao"]}]");
            versaoRodape.Alignment = Element.ALIGN_RIGHT;

            documento.Add(versaoRodape);

            documento.Close();
        }

        private static Document CriaArquivoSalvo(string caminho)
        {
            Document documento = new Document(PageSize.A4);

            caminho = Path.Combine(caminho, $"TabelaNA-{DateTime.Now.Millisecond}.pdf");

            PdfWriter.GetInstance(
                document: documento,
                os: new FileStream(caminho, FileMode.Create)
            );

            return documento;
        }

        private static void AdicionaMetaDados(Document documento)
        {        
            documento.AddAuthor(ConfigurationManager.AppSettings["autor"].ToString());
            documento.AddCreator(ConfigurationManager.AppSettings["versao"].ToString());
            documento.AddKeywords(ConfigurationManager.AppSettings["palavrasChave"].ToString());
            documento.AddCreationDate();
            documento.AddTitle(ConfigurationManager.AppSettings["titulo"].ToString());
            documento.AddSubject(ConfigurationManager.AppSettings["assunto"].ToString());
        }

        private static string GeraNumeroAleatorio()
        {
            var random = BigInteger.genPseudoPrime(132, 100, new Random()).ToString();

            var resultado = new StringBuilder();

            foreach(var character in random)
            {
                resultado.Append(character);
                resultado.Append(" ");
            }

            return resultado.ToString();
        }
    }
}
