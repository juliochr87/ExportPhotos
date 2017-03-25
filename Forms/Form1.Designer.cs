namespace ExportPhotos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGenerarPdf = new System.Windows.Forms.Button();
            this.folderBrowserDialogInforme = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelMensaje = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxCorregimiento = new System.Windows.Forms.TextBox();
            this.textBoxDistrito = new System.Windows.Forms.TextBox();
            this.textBoxProvincia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxNumeroPredio = new System.Windows.Forms.TextBox();
            this.textBoxBeneficiario = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewOrden = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.labelMensajeVivienda = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listViewViviendas = new System.Windows.Forms.ListView();
            this.imageListOrden = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialogImagenes = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerarPdf
            // 
            this.buttonGenerarPdf.Location = new System.Drawing.Point(426, 70);
            this.buttonGenerarPdf.Name = "buttonGenerarPdf";
            this.buttonGenerarPdf.Size = new System.Drawing.Size(212, 34);
            this.buttonGenerarPdf.TabIndex = 0;
            this.buttonGenerarPdf.Text = "Generar Informe Seleccionado";
            this.buttonGenerarPdf.UseVisualStyleBackColor = true;
            this.buttonGenerarPdf.Click += new System.EventHandler(this.buttonGenerarPdf_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(14, 128);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(91, 17);
            this.labelMensaje.TabIndex = 6;
            this.labelMensaje.Text = "labelMensaje";
            this.labelMensaje.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1890, 862);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1882, 833);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Viviendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.labelMensaje);
            this.groupBox5.Controls.Add(this.buttonGenerarPdf);
            this.groupBox5.Location = new System.Drawing.Point(746, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(644, 152);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reportes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha informe:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2017, 2, 13, 23, 0, 49, 0);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(426, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(212, 35);
            this.button7.TabIndex = 12;
            this.button7.Text = "Guardar Informe";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBoxCorregimiento);
            this.groupBox2.Controls.Add(this.textBoxDistrito);
            this.groupBox2.Controls.Add(this.textBoxProvincia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCedula);
            this.groupBox2.Controls.Add(this.textBoxNumeroPredio);
            this.groupBox2.Controls.Add(this.textBoxBeneficiario);
            this.groupBox2.Controls.Add(this.textBoxNumeroCasa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 154);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Limpiar datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxCorregimiento
            // 
            this.textBoxCorregimiento.Location = new System.Drawing.Point(485, 84);
            this.textBoxCorregimiento.Name = "textBoxCorregimiento";
            this.textBoxCorregimiento.Size = new System.Drawing.Size(229, 22);
            this.textBoxCorregimiento.TabIndex = 11;
            // 
            // textBoxDistrito
            // 
            this.textBoxDistrito.Location = new System.Drawing.Point(485, 53);
            this.textBoxDistrito.Name = "textBoxDistrito";
            this.textBoxDistrito.Size = new System.Drawing.Size(229, 22);
            this.textBoxDistrito.TabIndex = 10;
            // 
            // textBoxProvincia
            // 
            this.textBoxProvincia.Location = new System.Drawing.Point(485, 24);
            this.textBoxProvincia.Name = "textBoxProvincia";
            this.textBoxProvincia.Size = new System.Drawing.Size(229, 22);
            this.textBoxProvincia.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Corregimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Distrito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Provincia:";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(135, 84);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(229, 22);
            this.textBoxCedula.TabIndex = 7;
            // 
            // textBoxNumeroPredio
            // 
            this.textBoxNumeroPredio.Location = new System.Drawing.Point(135, 112);
            this.textBoxNumeroPredio.Name = "textBoxNumeroPredio";
            this.textBoxNumeroPredio.Size = new System.Drawing.Size(229, 22);
            this.textBoxNumeroPredio.TabIndex = 8;
            this.textBoxNumeroPredio.TextChanged += new System.EventHandler(this.textBoxNumeroPredio_TextChanged);
            // 
            // textBoxBeneficiario
            // 
            this.textBoxBeneficiario.Location = new System.Drawing.Point(135, 53);
            this.textBoxBeneficiario.Name = "textBoxBeneficiario";
            this.textBoxBeneficiario.Size = new System.Drawing.Size(229, 22);
            this.textBoxBeneficiario.TabIndex = 6;
            // 
            // textBoxNumeroCasa
            // 
            this.textBoxNumeroCasa.Location = new System.Drawing.Point(135, 25);
            this.textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            this.textBoxNumeroCasa.Size = new System.Drawing.Size(229, 22);
            this.textBoxNumeroCasa.TabIndex = 5;
            this.textBoxNumeroCasa.TextChanged += new System.EventHandler(this.textBoxNumeroCasa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de predio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beneficiario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de casa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.listViewOrden);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1396, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 803);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Informe Fotográfico";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Informe Hidroestático";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Informe Electrico";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cantidad:";
            // 
            // listViewOrden
            // 
            this.listViewOrden.Location = new System.Drawing.Point(11, 70);
            this.listViewOrden.Name = "listViewOrden";
            this.listViewOrden.Size = new System.Drawing.Size(463, 727);
            this.listViewOrden.TabIndex = 6;
            this.listViewOrden.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpiar orden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Borrar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxConsulta);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.labelMensajeVivienda);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.listViewViviendas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1855, 833);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Viviendas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(16, 19);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(323, 22);
            this.textBoxConsulta.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(345, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 38);
            this.button8.TabIndex = 9;
            this.button8.Text = "Buscar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // labelMensajeVivienda
            // 
            this.labelMensajeVivienda.AutoSize = true;
            this.labelMensajeVivienda.ForeColor = System.Drawing.Color.Red;
            this.labelMensajeVivienda.Location = new System.Drawing.Point(909, 22);
            this.labelMensajeVivienda.Name = "labelMensajeVivienda";
            this.labelMensajeVivienda.Size = new System.Drawing.Size(54, 17);
            this.labelMensajeVivienda.TabIndex = 8;
            this.labelMensajeVivienda.Text = "label11";
            this.labelMensajeVivienda.Visible = false;
            this.labelMensajeVivienda.Click += new System.EventHandler(this.labelMensajeVivienda_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(533, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Consultar / Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(721, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listViewViviendas
            // 
            this.listViewViviendas.Location = new System.Drawing.Point(15, 70);
            this.listViewViviendas.Name = "listViewViviendas";
            this.listViewViviendas.Size = new System.Drawing.Size(1488, 688);
            this.listViewViviendas.TabIndex = 1;
            this.listViewViviendas.UseCompatibleStateImageBehavior = false;
            this.listViewViviendas.SelectedIndexChanged += new System.EventHandler(this.listViewViviendas_SelectedIndexChanged);
            // 
            // imageListOrden
            // 
            this.imageListOrden.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListOrden.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListOrden.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList;
            this.listView1.Location = new System.Drawing.Point(10, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1368, 572);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1240, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Limpiar imagenes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(935, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 35);
            this.button9.TabIndex = 8;
            this.button9.Text = "Abrir imagen";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1079, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 35);
            this.button10.TabIndex = 9;
            this.button10.Text = "Refrescar imagenes";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxPos);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Location = new System.Drawing.Point(6, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1384, 645);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagenes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Posición de imagen";
            // 
            // textBoxPos
            // 
            this.textBoxPos.Location = new System.Drawing.Point(144, 27);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(101, 22);
            this.textBoxPos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1914, 897);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar fotos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarPdf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInforme;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxCorregimiento;
        private System.Windows.Forms.TextBox textBoxDistrito;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxNumeroPredio;
        private System.Windows.Forms.TextBox textBoxBeneficiario;
        private System.Windows.Forms.TextBox textBoxNumeroCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listViewViviendas;
        private System.Windows.Forms.Label labelMensajeVivienda;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageListOrden;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogImagenes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPos;
    }
}

