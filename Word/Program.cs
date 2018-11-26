using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf;

            // Recebendo o nome para o Certificado
            System.Console.WriteLine("Informe nome completo: ");
            nome = Console.ReadLine();
            
            // Recebendo CPF do usuário
            System.Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();
            
            Console.Clear();

            Document doc = new Document();

            Section section = doc.AddSection();

            Paragraph titulo = section.AddParagraph();

            titulo.AppendText("CERTIFICADO");

            ParagraphStyle s1 = new ParagraphStyle(doc);

            s1.Name = "TitleTextColor";

            s1.CharacterFormat.TextColor = Color.Cyan;

            s1.CharacterFormat.FontName = "Times New Roman";

            s1.CharacterFormat.FontSize = 30;

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            doc.Styles.Add(s1);
            titulo.ApplyStyle (s1.Name);

            Paragraph texto = section.AddParagraph();

            texto.AppendText($"Certificamos que {nome} portador(a) do CPF {cpf}, está apto a utilizar a Spire.Doc para a manipulação de arquivos do Word através da linguagem de programação C#");

            ParagraphStyle s2 = new ParagraphStyle(doc);

            s2.Name = "BodyTextColor";

            s1.CharacterFormat.TextColor = Color.LightCoral;

            s1.CharacterFormat.FontName = "Algerian";

            s1.CharacterFormat.FontSize = 20;

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Justify;

            doc.Styles.Add(s2);
            texto.ApplyStyle(s2.Name);

            System.Console.WriteLine("Certificado obtido com sucesso!");

            doc.SaveToFile(@"C:\Users\35711103822\Desktop\Certificado.docx");
        }
    }
}
