using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportPhotos.Utils
{
    public class Pdf
    {
        private static String STRING_TITULO_FOTOGRAFICO_1 = ConfigurationManager.AppSettings["TITULO_INFORME_FOTOGRAFICO_1"];
        private static String STRING_TITULO_FOTOGRAFICO_2 = ConfigurationManager.AppSettings["TITULO_INFORME_FOTOGRAFICO_2"];

        private static String STRING_BENEFICIARIO = "      BENEFICIARIO:     ";
        private static String STRING_CEDULA =       "      CEDULA:                ";
        private static String STRING_NUMERO_CASA =  "      NO. CASA:             ";
        private static String STRING_PREDIO =       "      NO. PREDIO:         ";
        private static String STRING_UBICACION =    "      UBICACIÓN:          ";
        private static String STRING_FECHA =        "      FECHA:                 ";

        private void agregarEspacios(Document doc, int cantidad)
        {
            for (int i = 0; i <= cantidad; i++)
            {
                doc.Add(new Paragraph(" "));
            }
        }

        public void generarPdfInformeFotografico(String path, String beneficiario, String cedula, String numeroCasa, String numeroPredio, String provincia, String distrito, String corregimiento, String fecha, String rutaImagenes, ListView listViewOrden)
        {
            String cabezera = "Beneficiario: " + beneficiario + " / Cédula: " + cedula + " / Casa No.: " + numeroCasa;

            String StringTituloBeneficiario = STRING_BENEFICIARIO + beneficiario.ToUpper();
            String StringTituloCedula = STRING_CEDULA + cedula.ToUpper();
            String StringTituloNumeroCasa = STRING_NUMERO_CASA + numeroCasa.ToUpper();
            String StringTituloNumeroPredio = STRING_PREDIO + numeroPredio.ToUpper();
            String StringTituloUbicacion = STRING_UBICACION + provincia.ToUpper() + ", " + distrito.ToUpper() + ", " + corregimiento.ToUpper();
            String StringTituloFecha = STRING_FECHA + fecha.ToUpper();

            //iTextSharp.text.Image imagenLogo = iTextSharp.text.Image.GetInstance("C:/Programa/logo.jpg");
            //imagenLogo.BorderWidth = 0;
            //imagenLogo.ScalePercent(50f);
            //imagenLogo.Alignment = Element.ALIGN_CENTER;

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mecontelsa.S.A.");
            doc.AddCreator("Mecontelsa.S.A.");

            // Abrimos el archivo
            doc.Open();


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //PRIMERA PAGINA

            doc.Add(imprimirImagen(160, 550, 0, listViewOrden));

            agregarEspacios(doc, 16);
 
            // Escribimos el encabezamiento en el documento
            Paragraph tituloPortada = new Paragraph(STRING_TITULO_FOTOGRAFICO_1);
            tituloPortada.Alignment = Element.ALIGN_CENTER;
            
            Paragraph tituloPortada2 = new Paragraph(STRING_TITULO_FOTOGRAFICO_2);
            tituloPortada2.Alignment = Element.ALIGN_CENTER;

            Paragraph tituloBeneficiario = new Paragraph(StringTituloBeneficiario);
            tituloBeneficiario.Alignment = Element.ALIGN_LEFT;

            Paragraph tituloCedula = new Paragraph(StringTituloCedula);
            tituloCedula.Alignment = Element.ALIGN_LEFT;

            Paragraph tituloNumCasa = new Paragraph(StringTituloNumeroCasa);
            tituloNumCasa.Alignment = Element.ALIGN_LEFT;

            Paragraph tituloNumPredio = new Paragraph(StringTituloNumeroPredio);
            tituloNumPredio.Alignment = Element.ALIGN_LEFT;

            Paragraph tituloUbicacion = new Paragraph(StringTituloUbicacion);
            tituloUbicacion.Alignment = Element.ALIGN_LEFT;

            Paragraph tituloFecha = new Paragraph(StringTituloFecha);
            tituloFecha.Alignment = Element.ALIGN_LEFT;

            //tituloPortada.PaddingTop = 100;
            // tituloPortada.PaddingTop = 300;
            doc.Add(tituloPortada);
            doc.Add(Chunk.NEWLINE);
            doc.Add(tituloPortada2);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(tituloBeneficiario);        
            doc.Add(tituloCedula);           
            doc.Add(tituloNumCasa);    
            doc.Add(tituloNumPredio);            
            doc.Add(tituloUbicacion);          
            doc.Add(tituloFecha);
            doc.Add(Chunk.NEWLINE);
            // doc.Add(imagenLogo);

            doc.NewPage();


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //SEGUNDA PAGINA EN ADELANTE

            int cont = 0;
            int contIma = 0;
            Paragraph up = new Paragraph(cabezera);
            up.Alignment = Element.ALIGN_LEFT;

            Paragraph upLine = new Paragraph("_______________________________________________________________________________");
            upLine.Alignment = Element.ALIGN_LEFT;

         
            foreach (ListViewItem imagen in listViewOrden.Items)
            {
                if (cont == 0)
                {
                    doc.Add(up);             
                    doc.Add(upLine);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(imprimirImagen(20, 500, contIma, listViewOrden));
                }
                if (cont == 1)
                {
                    doc.Add(imprimirImagen(320, 500, contIma, listViewOrden));
                }
                if (cont == 2)
                {
                    doc.Add(imprimirImagen(20, 260, contIma, listViewOrden));
                }
                if (cont == 3)
                {
                    doc.Add(imprimirImagen(320, 260, contIma, listViewOrden));
                }
                if (cont == 4)
                {
                    doc.Add(imprimirImagen(20, 50, contIma, listViewOrden));
                }
                if (cont == 5)
                {
                    doc.Add(imprimirImagen(320, 50, contIma, listViewOrden));
                    cont = -1;

                    doc.NewPage();
                }

                cont++;
                contIma++;

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            doc.Close();
            writer.Close();

            AddPageNumber(path);
        }

        private void AddPageNumber(String ruta)
        {
            byte[] bytes = File.ReadAllBytes(ruta);
            Font blackFont = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);
            using (MemoryStream stream = new MemoryStream())
            {
                PdfReader reader = new PdfReader(bytes);
                using (PdfStamper stamper = new PdfStamper(reader, stream))
                {
                    int pages = reader.NumberOfPages;
                    for (int i = 2; i <= pages; i++)
                    {
                        ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase("Página "+i.ToString(), blackFont), 568f, 15f, 0);
                    }
                }
                bytes = stream.ToArray();
            }
            File.WriteAllBytes(ruta, bytes);
        }

        private iTextSharp.text.Image imprimirImagen(int x, int y, int item, ListView listViewOrden)
        {     

            String rutaImagen = listViewOrden.Items[item].SubItems[2].Text.ToString();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
            imagen.ScaleAbsoluteWidth(260);
            imagen.ScaleAbsoluteHeight(200);
            //  float percentage = 180 / imagen.Width;
            //  imagen.ScalePercent(percentage * 150);
            imagen.Alignment = Element.ALIGN_LEFT;
            imagen.SetAbsolutePosition(x, y);

            return imagen;
        }
    }
}
