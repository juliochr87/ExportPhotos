using ExportPhotos.Dao;
using ExportPhotos.Objects;
using ExportPhotos.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExportPhotos
{
    public partial class Form1 : Form
    {
        private static String STRING_NOMBRE_PROVINCIA_DEFECTO = "Darien";
        private static String STRING_PREFIJO_INFORME_FOTOGRAFICO = "IF_";
        private static String STRING_PREFIJO_INFORME_ELECTRICO = "IE_";
        private static String STRING_PREFIJO_INFORME_HIDROSTATICO = "IH_";

        public void cargarListViewViviendas()
        {
            listViewViviendas.View = View.Details;
            listViewViviendas.LabelEdit = false;
            listViewViviendas.AllowColumnReorder = false;
            //listView1.CheckBoxes = true;        
            listViewViviendas.FullRowSelect = true;
            listViewViviendas.GridLines = false;

            listViewViviendas.Columns.Add("Numero casa", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Beneficiario", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Cédula", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Predio", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Provincia", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Distrito", 150, HorizontalAlignment.Left);
            listViewViviendas.Columns.Add("Corregimiento", 150, HorizontalAlignment.Left);

            cargarViviendas();

        }

        public void iniciarListView()
        {
            listView1.View = View.LargeIcon;
       
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.FullRowSelect = true;
            listView1.GridLines = false;
            listView1.Columns.Add("Imagen", 600, HorizontalAlignment.Left);
            listView1.Click += ListView1_SelectedIndexChanged;
            imageList.ImageSize = new Size(156, 100);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listView1.LargeImageList = imageList;

            textBoxProvincia.Text = STRING_NOMBRE_PROVINCIA_DEFECTO;
        }

        public void iniciarListViewOrden()
        {
            listViewOrden.Columns.Add("Imagen", 50, HorizontalAlignment.Left);
            listViewOrden.Columns.Add("Orden", 50, HorizontalAlignment.Left);
            listViewOrden.Columns.Add("Ruta", 350, HorizontalAlignment.Left);
            listViewOrden.View = View.Details;
            listViewOrden.FullRowSelect = true;
            listViewOrden.LabelEdit = false;
            listViewOrden.Sorting = SortOrder.Ascending;
            listViewOrden.ListViewItemSorter = new IntegerComparer(1);

           
            imageListOrden.ImageSize = new Size(32, 32);
            listViewOrden.SmallImageList = imageListOrden;

        }

        public Form1()
        {
            InitializeComponent();

            iniciarListView();
            iniciarListViewOrden();
            cargarListViewViviendas();

            label8.Text = listViewOrden.Items.Count.ToString();
            labelIdModificar.Text = "0";
            labelIdModificar.Visible = false;

            textBoxNumeroCasa.LostFocus += TextBoxNumeroCasa_LostFocus;
        }

        private void TextBoxNumeroCasa_LostFocus(object sender, EventArgs e)
        {
            String numeroCasa = textBoxNumeroCasa.Text;

            Vivienda vivienda = new ViviendaDao().consultarViviendaPorNumeroCasa(numeroCasa);

            if (vivienda.Id != null)
            {
              
                DialogResult result = MessageBox.Show("Vivienda ya guardada. Cédula: " + vivienda.Cedula + " Nombre: " + vivienda.Beneficiario + ". Desea cargar la información?",
                "Alerta",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    cargarInformacion(vivienda);
                }
            }


        }

        public void cargarViviendas()
        {
            listViewViviendas.Items.Clear();

            List<Vivienda> listaViviendas = new ViviendaDao().consultarViviendas();

            foreach (Vivienda v in listaViviendas)
            {
                ListViewItem item = new ListViewItem(new[] { v.NumeroCasa, v.Beneficiario, v.Cedula, v.Predio, v.Provincia, v.Distrito, v.Corregimiento });
                item.ImageKey = v.Id;
                listViewViviendas.Items.Add(item);
            }
        }

        private void mostrarImagenes()
        {

            string[] imgList = Directory.GetFiles(textBoxRutaImagenes.Text, "*.jpg");

            if (imgList.Length != 0)
            {
                int cont = 0;
                foreach (String rutaImagen in imgList)
                {
                    ListViewItem item1 = new ListViewItem(rutaImagen, cont);

                    listView1.Items.Add(item1);

                    imageList.Images.Add(Bitmap.FromFile(rutaImagen));
                    imageListOrden.Images.Add(Bitmap.FromFile(rutaImagen));
                    cont++;
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewOrden.Sort();
          
            ListView lvi = (ListView)sender;
            foreach (ListViewItem l in lvi.Items)
            {
                if (l.Selected)
                {
                    String selectedImage = l.Text;
                    String pos = textBoxPos.Text;

                    ListViewItem item = new ListViewItem(new[] {"", pos, selectedImage });
                    item.ImageIndex = l.Index;

                    listViewOrden.Items.Add(item);
                    
                }
            }

            label8.Text = listViewOrden.Items.Count.ToString();
            textBoxPos.Text = "";
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaImagenes.Text = folderBrowserDialog.SelectedPath;
                mostrarImagenes();
            }

        }

        private void buttonRutaPdf_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaPDF.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonGenerarPdf_Click(object sender, EventArgs e)
        {
            

            label8.Text = listViewOrden.Items.Count.ToString();

            if (textBoxBeneficiario.Text.Equals("") ||
                textBoxCedula.Text.Equals("") ||
                textBoxCorregimiento.Text.Equals("") ||
                textBoxDistrito.Text.Equals("") ||
                textBoxNumeroCasa.Text.Equals("") ||
                textBoxNumeroPredio.Text.Equals("") ||
                textBoxProvincia.Text.Equals("") ||
                textBoxRutaImagenes.Text.Equals("") ||
                textBoxRutaPDF.Text.Equals("") || listViewOrden.Items.Count == 0)
            {
                labelMensaje.Text = "Por favor complete todos los campos";
                labelMensaje.Visible = true;
            }
            else
            {
                labelMensaje.Visible = false;

                String rutaImagenes = textBoxRutaImagenes.Text;
                String path = "";

                if (radioButton3.Checked.Equals(true))
                {
                    path = textBoxRutaPDF.Text + "\\"+STRING_PREFIJO_INFORME_FOTOGRAFICO + textBoxNumeroCasa.Text + ".pdf";
                    new Pdf().generarPdfInformeFotografico(path, textBoxBeneficiario.Text, textBoxCedula.Text, textBoxNumeroCasa.Text, textBoxNumeroPredio.Text, textBoxProvincia.Text, textBoxDistrito.Text, textBoxCorregimiento.Text, dateTimePicker1.Text, rutaImagenes, listViewOrden);                 
                }
                if (radioButton2.Checked.Equals(true))
                {
                     path = textBoxRutaPDF.Text + "\\" + STRING_PREFIJO_INFORME_HIDROSTATICO + textBoxNumeroCasa.Text + ".pdf";
                }
                if (radioButton1.Checked.Equals(true))
                {
                     path = textBoxRutaPDF.Text + "\\" + STRING_PREFIJO_INFORME_ELECTRICO + textBoxNumeroCasa.Text + ".pdf";
                }

                MessageBox.Show("Informe generado: " + path);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewOrden.Items.Clear();
            label8.Text = listViewOrden.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listViewOrden.SelectedItems)
            {
                listViewOrden.Items.Remove(l);
            }

            label8.Text = listViewOrden.Items.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxBeneficiario.Text = "";
            textBoxCedula.Text = "";
            textBoxCorregimiento.Text = "";
            textBoxDistrito.Text = "";
            textBoxNumeroCasa.Text = "";
            textBoxNumeroPredio.Text = "";
            textBoxProvincia.Text = STRING_NOMBRE_PROVINCIA_DEFECTO;
            // textBoxRutaImagenes.Text = "";
            // textBoxRutaPDF.Text = "";
        }
 
        private void generarPdf()
        {
            String path = textBoxRutaPDF.Text + "\\" + textBoxNumeroCasa.Text + ".pdf";
            String textoTituloPortada = "No. de casa: " + textBoxNumeroCasa.Text + " / Nombre beneficiario: " + textBoxBeneficiario.Text + " / Cédula: " + textBoxCedula.Text + " / Provincia: " + textBoxProvincia.Text + " / Corregimiento: " + textBoxCorregimiento.Text + " / Distrito: " + textBoxDistrito.Text;
            String cabezera = "Casa No. " + textBoxNumeroCasa.Text + " / Beneficiario: " + textBoxBeneficiario.Text + " / Cédula: " + textBoxCedula.Text;
            String rutaImagenes = textBoxRutaImagenes.Text;

            iTextSharp.text.Image imagenLogo = iTextSharp.text.Image.GetInstance("C:/Programa/logo.jpg");
            imagenLogo.BorderWidth = 0;
            imagenLogo.ScalePercent(50f);
            imagenLogo.Alignment = Element.ALIGN_CENTER;

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


            doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" ")); doc.Add(new Paragraph(" "));
            // Escribimos el encabezamiento en el documento
            Paragraph tituloPortada = new Paragraph(textoTituloPortada);
            tituloPortada.Alignment = Element.ALIGN_CENTER;
            //tituloPortada.PaddingTop = 100;
            // tituloPortada.PaddingTop = 300;
            doc.Add(tituloPortada);
            doc.Add(Chunk.NEWLINE);
            doc.Add(imagenLogo);

            doc.NewPage();


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //SEGUNDA PAGINA EN ADELANTE

            int cont = 0;
            int contIma = 0;
            Paragraph up = new Paragraph(cabezera);
            up.Alignment = Element.ALIGN_LEFT;


            foreach (ListViewItem imagen in listViewOrden.Items)
            {
                if (cont == 0)
                {
                    doc.Add(up);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(imprimirImagen(20, 500, contIma));
                }
                if (cont == 1)
                {
                    doc.Add(imprimirImagen(320, 500, contIma));
                }
                if (cont == 2)
                {
                    doc.Add(imprimirImagen(20, 260, contIma));
                }
                if (cont == 3)
                {
                    doc.Add(imprimirImagen(320, 260, contIma));
                }
                if (cont == 4)
                {
                    doc.Add(imprimirImagen(20, 50, contIma));
                }
                if (cont == 5)
                {
                    doc.Add(imprimirImagen(320, 50, contIma));
                    cont = -1;
                    doc.NewPage();
                }

                cont++;
                contIma++;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            doc.Close();
            writer.Close();

        }

        private iTextSharp.text.Image imprimirImagen(int x, int y, int item)
        {
            String rutaImagenes = textBoxRutaImagenes.Text;

            String rutaImagen = listViewOrden.Items[item].SubItems[1].Text.ToString();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
            imagen.ScaleAbsoluteWidth(260);
            imagen.ScaleAbsoluteHeight(200);
            //  float percentage = 180 / imagen.Width;
            //  imagen.ScalePercent(percentage * 150);
            imagen.Alignment = Element.ALIGN_LEFT;
            imagen.SetAbsolutePosition(x, y);

            return imagen;
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (ListViewItem i in listViewViviendas.SelectedItems)
            {
                flag = 1;
            }

            if (flag == 1)
            {
                foreach (ListViewItem i in listViewViviendas.SelectedItems)
                {
                    new ViviendaDao().borrarVivienda(i.ImageKey);
                    new ImagenDao().borrarImagen(i.ImageKey);
                }
                cargarViviendas();
            }
            else
            {
                labelMensajeVivienda.Text = "Por favor seleccione una vivienda.";
                labelMensajeVivienda.Visible = true;
            }
        }

        private void cargarInformacion(Vivienda vivienda)
        {
            listViewOrden.Items.Clear();

            textBoxBeneficiario.Text = vivienda.Beneficiario;
            textBoxCedula.Text = vivienda.Cedula;
            textBoxCorregimiento.Text = vivienda.Corregimiento;
            textBoxDistrito.Text = vivienda.Distrito;
            textBoxNumeroCasa.Text = vivienda.NumeroCasa;
            textBoxNumeroPredio.Text = vivienda.Predio;
            textBoxProvincia.Text = vivienda.Provincia;
            labelIdModificar.Text = vivienda.Id;

            List<Imagen> listaImagenes = new ImagenDao().consultarImagenes(vivienda.Id);
            foreach (Imagen i in listaImagenes)
            {
                ListViewItem item = new ListViewItem(new[] { i.Orden, i.Ruta });

                listViewOrden.Items.Add(item);

            }
            label8.Text = listViewOrden.Items.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int flag = 0;
            String id = "";
            foreach (ListViewItem i in listViewViviendas.SelectedItems)
            {
                flag = 1;

                id = i.ImageKey;
            }
            if (flag == 1)
            {
                tabControl1.SelectedTab = tabPage1;

                listViewOrden.Items.Clear();

                Vivienda vivienda = new ViviendaDao().consultarVivienda(id);

                cargarInformacion(vivienda);

            }
            else
            {
                labelMensajeVivienda.Text = "Por favor seleccione una vivienda.";
                labelMensajeVivienda.Visible = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxBeneficiario.Text.Equals("") ||
                textBoxCedula.Text.Equals("") ||
                textBoxCorregimiento.Text.Equals("") ||
                textBoxDistrito.Text.Equals("") ||
                textBoxNumeroCasa.Text.Equals("") ||
                textBoxNumeroPredio.Text.Equals("") ||
                textBoxProvincia.Text.Equals(""))
            {
                labelMensaje.Text = "Por favor complete todos los campos";
                labelMensaje.Visible = true;
            }
            else
            {
                String beneficiario = textBoxBeneficiario.Text;
                String cedula = textBoxCedula.Text;
                String corregimiento = textBoxCorregimiento.Text;
                String distrito = textBoxDistrito.Text;
                String numeroCasa = textBoxNumeroCasa.Text;
                String predio = textBoxNumeroPredio.Text;
                String provincia = textBoxProvincia.Text;
                String rutaImagenes = textBoxRutaImagenes.Text;
                String rutaPDF = textBoxRutaPDF.Text;

                if (!labelIdModificar.Equals(""))
                {
                    new ViviendaDao().borrarVivienda(labelIdModificar.Text);
                    new ImagenDao().borrarImagen(labelIdModificar.Text);
                }
                int id = new ViviendaDao().guardarVivienda(numeroCasa, beneficiario, cedula, predio, provincia, distrito, corregimiento);

                foreach (ListViewItem imagen in listViewOrden.Items)
                {
                    String orden = imagen.SubItems[0].Text;
                    String rutaImagen = imagen.SubItems[1].Text;
                    new ImagenDao().guardarImagen(rutaImagen, orden, id);
                }

                MessageBox.Show("Registro guardado correctamente!");
            }
        }

        private void listViewViviendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxConsulta.Text;

            listViewViviendas.Items.Clear();

            List<Vivienda> listaViviendas = new ViviendaDao().consultarViviendas(busqueda);

            foreach (Vivienda v in listaViviendas)
            {
                ListViewItem item = new ListViewItem(new[] { v.NumeroCasa, v.Beneficiario, v.Cedula, v.Predio, v.Provincia, v.Distrito, v.Corregimiento });
                item.ImageKey = v.Id;
                listViewViviendas.Items.Add(item);
            }

        }

        private void labelMensajeVivienda_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroCasa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
