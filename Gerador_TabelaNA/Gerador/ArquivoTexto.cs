namespace Gerador_TabelaNA
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Reflection;

    public static class ArquivoTexto
    {
        public static void  NovaTabela(string nomeUniversidade, string nomeTabela, string nomeProfessor, string nomeCurso, int periodo, string caminhoSalvar)
        {
            var documento = CriaArquivo(caminhoSalvar);

            documento.Open();

            var tituloUniversidade = new Paragraph(nomeUniversidade);
            tituloUniversidade.Alignment = Element.ALIGN_CENTER;
            
            documento.Add(tituloUniversidade);
            documento.Add(new Paragraph($"Professor: { nomeProfessor}"));
            documento.Add(new Paragraph($"Tipo: {nomeTabela}"));

            documento.Add(new Paragraph($"Curso: {nomeCurso} - {periodo}º período"));
            documento.Add(new Paragraph(" "));
            
            for (int i = 1; i <= 35; i++)
            {
                var randomico = NumeroAleatorio.GerarNovo();

                Paragraph linha = new Paragraph($"{i.ToString()}      {randomico}");
                linha.Alignment = Element.ALIGN_JUSTIFIED;
                
                documento.Add(linha);
            }

            documento.Add(new Paragraph(" "));

            var versaoRodape = new Paragraph($"Feito por: Vitor Cioletti Morais [Lunae {Assembly.GetEntryAssembly().GetName().Version}]");
            versaoRodape.Alignment = Element.ALIGN_RIGHT;

            documento.Add(versaoRodape);

            AdicionaMetaDados(documento);

            documento.Close();
        }

        private static Document CriaArquivo(string caminho)
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
    }
}
