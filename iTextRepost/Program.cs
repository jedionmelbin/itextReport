using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTextRepost
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileStream fs = new FileStream("D:\\document.pdf", FileMode.Create);

            var pgSize = new Rectangle(74.1F, 137.6F);
            var document = new Document(pgSize, 5, 5, 5, 5);

            // Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 2, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.AddAuthor("Jedion Melbin");
            document.AddCreator("Sample application using iTextSharp");
            document.AddKeywords("PDF tutorial education");
            document.AddSubject("Document subject - Describing the steps creating a PDF document");
            document.AddTitle("The document title - PDF creation using iTextSharp");


            document.Open();
            var titleFont = FontFactory.GetFont("Courier", 4, Font.BOLD);
            var titulo = new Paragraph("INVERSIONES SAZON DE SAN SAN ISIDRO E.I.E.L ", _standardFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Font = titleFont;
            titulo.PaddingTop = 0;
            document.Add(titulo);

            var nroRuc = new Paragraph("RUC: 202525252525", _standardFont);
            nroRuc.Alignment = Element.ALIGN_CENTER;
            document.Add(nroRuc);

            var address = new Paragraph("AV URUBAMBA 513 ATE VITARTE URB SAN JUAN DE LIMA PERU", _standardFont);
            address.Alignment = Element.ALIGN_CENTER;
            // address.Font = titleFont;
            document.Add(address);

            var telefono = new Paragraph("Telefono: 940621487", _standardFont);
            telefono.Alignment = Element.ALIGN_CENTER;
            document.Add(telefono);

            var tipoDoc = new Paragraph("BOLETA DE VENTA ELECTRONICA", _standardFont);
            tipoDoc.Alignment = Element.ALIGN_CENTER;
            tipoDoc.Font = titleFont;
            document.Add(tipoDoc);

            var serie = new Paragraph("B001-00001", _standardFont);
            serie.Alignment = Element.ALIGN_CENTER;
            document.Add(serie);

            var linea = new Paragraph(Constant.LINEA, _standardFont);
            linea.Alignment = Element.ALIGN_CENTER;
            document.Add(linea);

            var nombres = new Paragraph("DNI/NOMBRE: 47680041 JEDION MELBIN PAUCAR CARDENAS ", _standardFont);
            nombres.Alignment = Element.ALIGN_CENTER;
            document.Add(nombres);

            var direccion = new Paragraph("DIRECCION: AV LOS FICUS ATE VITARTE LIMA PERU ", _standardFont);
            direccion.Alignment = Element.ALIGN_CENTER;
            document.Add(direccion);

            linea.Alignment = Element.ALIGN_CENTER;
            document.Add(linea);

            float[] widths = new float[] { 0.5F, 0.2F, 0.2F, 0.3F, 0.2F};
            PdfPTable tblPrueba = new PdfPTable(5);
            tblPrueba.SetWidths(widths);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clDescripcion = new PdfPCell(new Phrase("Descripción", _standardFont));
            clDescripcion.BorderWidth = 0;
  

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cant.", _standardFont));
            clCantidad.BorderWidth = 0;
            //clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clUm = new PdfPCell(new Phrase("UM", _standardFont));
            clUm.BorderWidth = 0;

            PdfPCell clPrecioUnit = new PdfPCell(new Phrase("P. Unit", _standardFont));
            clPrecioUnit.BorderWidth = 0;

            PdfPCell clTotal = new PdfPCell(new Phrase("Total", _standardFont));
            clTotal.BorderWidth = 0;

            //clPais.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clDescripcion);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clUm);
            tblPrueba.AddCell(clPrecioUnit);
            tblPrueba.AddCell(clTotal);

            // Llenamos la tabla con información
            clDescripcion = new PdfPCell(new Phrase("Menu producto", _standardFont));
            clDescripcion.BorderWidth = 0;

            clCantidad = new PdfPCell(new Phrase("1.0", _standardFont));
            clCantidad.BorderWidth = 0;

            clUm = new PdfPCell(new Phrase("NIU", _standardFont));
            clUm.BorderWidth = 0;

            clPrecioUnit = new PdfPCell(new Phrase("25.30", _standardFont));
            clPrecioUnit.BorderWidth = 0;

            clTotal = new PdfPCell(new Phrase("35.30", _standardFont));
            clTotal.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clDescripcion);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clUm);
            tblPrueba.AddCell(clPrecioUnit);
            tblPrueba.AddCell(clTotal);

            document.Add(tblPrueba);

            linea.Alignment = Element.ALIGN_CENTER;
            document.Add(linea);

            linea.Alignment = Element.ALIGN_CENTER;
            document.Add(linea);

            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
