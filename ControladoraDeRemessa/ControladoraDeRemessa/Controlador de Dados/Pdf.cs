using ControladoraDeRemessa.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace ControladoraDeRemessa.Controlador_de_Dados
{
    public class Pdf
    {
        public static void CriarPdf(Cliente cliente)
        {
            Document document = new Document(PageSize.A4);
            string caminho = @"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + cliente.Nome + @"\" + cliente.Remessa.NumeroDaRemessa + "Fechada.pdf";
            document.SetMargins(40, 40, 40, 80);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));

            document.Open();

            string caminhoImagem = @"C:\Users\" + Environment.UserName + @"\Documents\Remessa\icon.jpg";

            Image imagem = Image.GetInstance(caminhoImagem);

            imagem.SetAbsolutePosition(250, 700);
            imagem.ScaleToFit(100, 200);

            document.Add(imagem);

            document.Add(new Paragraph($"\n\n\nNome do cliente:{cliente.Nome}"));
            document.Add(new Paragraph($"\nNumero da remessa:{cliente.Remessa.NumeroDaRemessa}"));

            document.Add(new Paragraph($"\nRemessa de Entrada:\n\n\n"));

            PdfPTable tabelaEntrada = new PdfPTable(6);

            tabelaEntrada.AddCell("Nome");
            tabelaEntrada.AddCell("Modelo");
            tabelaEntrada.AddCell("Código");
            tabelaEntrada.AddCell("Código de barras");
            tabelaEntrada.AddCell("Pacotes");
            tabelaEntrada.AddCell("Barras");

            foreach (Perfil perfil in cliente.Remessa.RemessaEntrada) 
            {
                tabelaEntrada.AddCell(perfil.Nome);
                tabelaEntrada.AddCell(perfil.Modelo);
                tabelaEntrada.AddCell(perfil.Codigo);
                tabelaEntrada.AddCell(perfil.CodigoDeBarrras);
                tabelaEntrada.AddCell(perfil.Pacotes.ToString());
                tabelaEntrada.AddCell(perfil.Barras.ToString());
            }

            document.Add(tabelaEntrada);

            document.Add(new Paragraph($"\nRemessa de Saida:\n\n\n"));

            PdfPTable tabelaSaida = new PdfPTable(6);

            tabelaSaida.AddCell("Nome");
            tabelaSaida.AddCell("Modelo");
            tabelaSaida.AddCell("Código");
            tabelaSaida.AddCell("Código de barras");
            tabelaSaida.AddCell("Pacotes");
            tabelaSaida.AddCell("Barras");

            foreach (Perfil perfil in cliente.Remessa.RemessaSaida)
            {
                tabelaSaida.AddCell(perfil.Nome);
                tabelaSaida.AddCell(perfil.Modelo);
                tabelaSaida.AddCell(perfil.Codigo);
                tabelaSaida.AddCell(perfil.CodigoDeBarrras);
                tabelaSaida.AddCell(perfil.Pacotes.ToString());
                tabelaSaida.AddCell(perfil.Barras.ToString());
            }

            document.Add(tabelaSaida);

            document.Close();
        }
    }
}
