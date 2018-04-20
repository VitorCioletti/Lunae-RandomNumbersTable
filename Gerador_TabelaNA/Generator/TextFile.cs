namespace TableGenerator
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public static class TextFile
    {
        private static Document document;

        public static Task NewTable(string universityName, string tableName, string teacherName, string courseName, string semester, string savePath)
        {
            return Task.Run( () =>
                {
                    Thread.Sleep(1500);

                    CreateFile(savePath);

                    document.Open();

                    CreateHeader(universityName, teacherName, tableName, courseName, semester);
                    CreateBody();
                    CreateFooter("Vitor Cioletti Morais");

                    AddMetadata();

                    document.Close();
                }
            );
  
        }

        private static void CreateHeader(string universityName, string tableName, string teacherName, string courseName, string semester)
        {
            var tituloUniversidade = new Paragraph(universityName);
            tituloUniversidade.Alignment = Element.ALIGN_CENTER;

            document.Add(tituloUniversidade);
            document.Add(new Paragraph($"Teacher: { teacherName}"));
            document.Add(new Paragraph($"Type: {tableName}"));

            document.Add(new Paragraph($"Course: {courseName} - {semester}º semester"));
            document.Add(Chunk.NEWLINE);
        }

        private static void CreateBody()
        {
            CreateBodyHeader();

            for (int i = 1; i <= 39; i++)
            {
                var random = RandomNumber.GenerateNew();

                var twoDigitInteger = String.Format("{0:00}", i);

                var phrase = new Phrase();
                phrase.Add(new Chunk(twoDigitInteger, FontFactory.GetFont("Arial", 9, Font.NORMAL)));
                phrase.Add(new Chunk($"       {random}"));

                Paragraph line = new Paragraph(phrase);
                line.Alignment = Element.ALIGN_JUSTIFIED;

                document.Add(line);
            }
        }
        
        private static void CreateBodyHeader()
        {
            var tableHeader = new StringBuilder();
            tableHeader.Append("             1");

            int headerValue = 6;
            for (int i = 2; i <= 12; i++)
            {
                if (headerValue > 10)
                    tableHeader.Append($"            {headerValue}");
                else
                    tableHeader.Append($"               {headerValue}");

                headerValue += 5;
            }

            var font = FontFactory.GetFont("Arial", 9, Font.NORMAL);
            var tableHeaderParagraph = new Paragraph(tableHeader.ToString(), font);

            document.Add(tableHeaderParagraph);
        }

        private static void CreateFooter(string creator)
        {
            document.Add(Chunk.NEWLINE);
            var version = new Paragraph($"Made by: {creator} [Lunae {Assembly.GetEntryAssembly().GetName().Version}]");
            version.Alignment = Element.ALIGN_RIGHT;

            document.Add(version);
        }

        private static void CreateFile(string path)
        {
            document = new Document(PageSize.A4);

            path = Path.Combine(path, $"table-{DateTime.Now.Millisecond}.pdf");

            PdfWriter.GetInstance(
                document: document,
                os: new FileStream(path, FileMode.Create)
            );
        }

        private static void AddMetadata()
        {
            document.AddAuthor(ConfigurationManager.AppSettings["autor"].ToString());
            document.AddCreator(Assembly.GetEntryAssembly().GetName().Version.ToString());
            document.AddKeywords(ConfigurationManager.AppSettings["palavrasChave"].ToString());
            document.AddCreationDate();
            document.AddTitle(ConfigurationManager.AppSettings["titulo"].ToString());
            document.AddSubject(ConfigurationManager.AppSettings["assunto"].ToString());
        }
    }
}
