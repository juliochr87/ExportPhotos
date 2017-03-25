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
    public class Informe : Pdf
    {
        private static String STRING_RUTA_IMAGENES = ConfigurationManager.AppSettings["RUTA_IMAGENES_FIJAS"];

        private static String STRING_TITULO_FOTOGRAFICO_1 = ConfigurationManager.AppSettings["TITULO_INFORME_FOTOGRAFICO_1"];
        private static String STRING_TITULO_FOTOGRAFICO_2 = ConfigurationManager.AppSettings["TITULO_INFORME_FOTOGRAFICO_2"];

        private static String STRING_TITULO_INFORME_ELECTRICO_1 = ConfigurationManager.AppSettings["TITULO_INFORME_ELECTRICO_1"];
        private static String STRING_TITULO_INFORME_ELECTRICO_2 = ConfigurationManager.AppSettings["TITULO_INFORME_ELECTRICO_2"];

        private static String STRING_TITULO_INFORME_HIDROESTATICO_1 = ConfigurationManager.AppSettings["TITULO_INFORME_HIDROESTATICO_1"];
        private static String STRING_TITULO_INFORME_HIDROESTATICO_2 = ConfigurationManager.AppSettings["TITULO_INFORME_HIDROESTATICO_2"];

        private static String STRING_NOMBRE_EMPRESA = "Mecontelsa.S.A.";

        public void generarPdfInformeHidroestatico(String path, String beneficiario, String cedula, String numeroCasa, String numeroPredio, String provincia, String distrito, String corregimiento, String fecha, String rutaImagenes, ListView listViewOrden)
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.AddTitle(STRING_NOMBRE_EMPRESA);
            doc.AddCreator(STRING_NOMBRE_EMPRESA);

            doc.Open();

            //PRIMERA PAGINA PORTADA
            doc = generarPortada(doc, STRING_TITULO_INFORME_HIDROESTATICO_1, STRING_TITULO_INFORME_HIDROESTATICO_2, beneficiario, cedula, numeroCasa, numeroPredio, provincia, distrito, corregimiento, fecha, rutaImagenes, listViewOrden);
            //FIN PRIMERA PAGINA

            String cabezera = generarCabezera(beneficiario, cedula, numeroCasa);
            doc = imprimirCabezera(doc, cabezera);
 
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/hidroestatico/Hidro_1.jpg");
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/hidroestatico/Hidro_2.jpg");
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/hidroestatico/Hidro_3.jpg");
            doc.NewPage();

            doc = imprimirCabezera(doc, cabezera);
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/hidroestatico/Hidro_4.jpg");

            doc.NewPage();
            doc = imprimirCabezera(doc, cabezera);
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/hidroestatico/Hidro_6.jpg");

            doc.NewPage();
            doc = imprimirImagenesOrden(doc, cabezera, listViewOrden);
            
            doc.Close();
            writer.Close();

            AddPageNumber(path);
        }

        public void generarPdfInformeElectrico(String path, String beneficiario, String cedula, String numeroCasa, String numeroPredio, String provincia, String distrito, String corregimiento, String fecha, String rutaImagenes, ListView listViewOrden)
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.AddTitle(STRING_NOMBRE_EMPRESA);
            doc.AddCreator(STRING_NOMBRE_EMPRESA);

            doc.Open();

            //PRIMERA PAGINA PORTADA
            doc = generarPortada(doc, STRING_TITULO_INFORME_ELECTRICO_1, STRING_TITULO_INFORME_ELECTRICO_2, beneficiario, cedula, numeroCasa, numeroPredio, provincia, distrito, corregimiento, fecha, rutaImagenes, listViewOrden);
            //FIN PRIMERA PAGINA


            String cabezera = generarCabezera(beneficiario, cedula, numeroCasa);

            doc = imprimirCabezera(doc, cabezera);
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_1.jpg");
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_2.jpg");
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_3.jpg");
            doc.NewPage();
            doc = imprimirCabezera(doc, cabezera);
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_4a.jpg");
            doc.NewPage();
            doc = imprimirCabezera(doc, cabezera);
            doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_4b.jpg");

           // doc.NewPage();
           // doc = imprimirCabezera(doc, cabezera);
           // doc = imprimirImagenEstatica(doc, STRING_RUTA_IMAGENES + "/electrico/Electrico_6.jpg");

            doc.NewPage();
            doc = imprimirImagenesOrden(doc, cabezera, listViewOrden);
         
            doc.Close();
            writer.Close();

            AddPageNumber(path);
        }

        public void generarPdfInformeFotografico(String path, String beneficiario, String cedula, String numeroCasa, String numeroPredio, String provincia, String distrito, String corregimiento, String fecha, String rutaImagenes, ListView listViewOrden)
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.AddTitle(STRING_NOMBRE_EMPRESA);
            doc.AddCreator(STRING_NOMBRE_EMPRESA);

            doc.Open();

            //PRIMERA PAGINA PORTADA
            doc = generarPortada(doc, STRING_TITULO_FOTOGRAFICO_1, STRING_TITULO_FOTOGRAFICO_2, beneficiario, cedula, numeroCasa, numeroPredio, provincia, distrito, corregimiento, fecha, rutaImagenes, listViewOrden);
            //FIN PRIMERA PAGINA

            String cabezera = generarCabezera(beneficiario, cedula, numeroCasa);

            doc = imprimirImagenesOrden(doc, cabezera, listViewOrden);

            doc.Close();
            writer.Close();

            AddPageNumber(path);
        }
    }
}
