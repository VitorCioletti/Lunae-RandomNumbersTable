namespace Gerador_TabelaNA
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public static class ArquivoTexto
    {
        private static Document documento;

        public static void NovaTabela(string nomeUniversidade, string nomeTabela, string nomeProfessor, string nomeCurso, string periodo, string caminhoSalvar)
        {
            CriaArquivo(caminhoSalvar);

            documento.Open();

            MontaCabecalho(nomeUniversidade, nomeProfessor, nomeTabela, nomeCurso, periodo);
            MontaCorpoTabela();
            MontaRodape("Vitor Cioletti Morais"); 

            AdicionaMetaDados();

            documento.Close();
        }

        private static void MontaCabecalho(string nomeUniversidade, string nomeProfessor, string nomeTabela, string nomeCurso, string periodo)
        {
            var tituloUniversidade = new Paragraph(nomeUniversidade);
            tituloUniversidade.Alignment = Element.ALIGN_CENTER;

            documento.Add(tituloUniversidade);
            documento.Add(new Paragraph($"Professor: { nomeProfessor}"));
            documento.Add(new Paragraph($"Tipo: {nomeTabela}"));

            documento.Add(new Paragraph($"Curso: {nomeCurso} - {periodo}º período"));
            documento.Add(Chunk.NEWLINE);
        }

        private static void MontaCorpoTabela()
        {
            CriaCabecalhoTabela();

            for (int i = 1; i <= 39; i++)
            {
                var randomico = NumeroAleatorio.GerarNovo();

                var inteiroComDoisDigitos = String.Format("{0:00}", i);

                var frase = new Phrase();
                frase.Add(new Chunk(inteiroComDoisDigitos, FontFactory.GetFont("Arial", 9, Font.NORMAL)));
                frase.Add(new Chunk($"       {randomico}"));

                Paragraph linha = new Paragraph(frase);
                linha.Alignment = Element.ALIGN_JUSTIFIED;

                documento.Add(linha);
            }
        }
        
        private static void CriaCabecalhoTabela()
        {
            var cabecalhoTabela = new StringBuilder();
            cabecalhoTabela.Append("             1");

            for (int i = 2; i <= 12; i++)
            {
                if (i > 10)
                    cabecalhoTabela.Append($"            {i}");
                else
                    cabecalhoTabela.Append($"              {i}");
            }

            var fonte = FontFactory.GetFont("Arial", 9, Font.NORMAL);
            var paragrafoCabecalhoTabela = new Paragraph(cabecalhoTabela.ToString(), fonte);

            documento.Add(paragrafoCabecalhoTabela);
        }

        private static void MontaRodape(string criador)
        {
            documento.Add(Chunk.NEWLINE);
            var versaoRodape = new Paragraph($"Feito por: {criador} [Lunae {Assembly.GetEntryAssembly().GetName().Version}]");
            versaoRodape.Alignment = Element.ALIGN_RIGHT;

            documento.Add(versaoRodape);
        }

        private static void CriaArquivo(string caminho)
        {
            documento = new Document(PageSize.A4);

            caminho = Path.Combine(caminho, $"TabelaNA-{DateTime.Now.Millisecond}.pdf");

            PdfWriter.GetInstance(
                document: documento,
                os: new FileStream(caminho, FileMode.Create)
            );
        }

        private static void AdicionaMetaDados()
        {
            documento.AddAuthor(ConfigurationManager.AppSettings["autor"].ToString());
            documento.AddCreator(ConfigurationManager.AppSettings["versao"].ToString());
            documento.AddKeywords(ConfigurationManager.AppSettings["palavrasChave"].ToString());
            documento.AddCreationDate();
            documento.AddTitle(ConfigurationManager.AppSettings["titulo"].ToString());
            documento.AddSubject(ConfigurationManager.AppSettings["assunto"].ToString());
        }
    }
}
