namespace sistema.presentacion
{
    partial class frmArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.BtnGuardarCodigo = new System.Windows.Forms.Button();
            this.BtnGenerarCodigo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkseleccionar = new System.Windows.Forms.CheckBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btndesactivar = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgblistado = new System.Windows.Forms.DataGridView();
            this.tabgeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*)Indica que el campo es obligatorio";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Location = new System.Drawing.Point(419, 8);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(57, 28);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescripcion.Location = new System.Drawing.Point(817, 312);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(229, 56);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Location = new System.Drawing.Point(49, 117);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(282, 28);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.TxtStock);
            this.tabPage2.Controls.Add(this.TxtPrecioVenta);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.BtnGuardarCodigo);
            this.tabPage2.Controls.Add(this.BtnGenerarCodigo);
            this.tabPage2.Controls.Add(this.TxtCodigo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.PicImagen);
            this.tabPage2.Controls.Add(this.BtnCargarImagen);
            this.tabPage2.Controls.Add(this.TxtImagen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CboCategoria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnactualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btncancelar);
            this.tabPage2.Controls.Add(this.btninsertar);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1228, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // TxtStock
            // 
            this.TxtStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStock.Location = new System.Drawing.Point(384, 378);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(201, 28);
            this.TxtStock.TabIndex = 23;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrecioVenta.Location = new System.Drawing.Point(384, 290);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(201, 28);
            this.TxtPrecioVenta.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "stock(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Precio de venta(*)";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.PanelCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelCodigo.Location = new System.Drawing.Point(48, 268);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(283, 126);
            this.PanelCodigo.TabIndex = 19;
            // 
            // BtnGuardarCodigo
            // 
            this.BtnGuardarCodigo.Enabled = false;
            this.BtnGuardarCodigo.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCodigo.Location = new System.Drawing.Point(164, 227);
            this.BtnGuardarCodigo.Name = "BtnGuardarCodigo";
            this.BtnGuardarCodigo.Size = new System.Drawing.Size(109, 35);
            this.BtnGuardarCodigo.TabIndex = 18;
            this.BtnGuardarCodigo.Text = "Guardar";
            this.BtnGuardarCodigo.UseVisualStyleBackColor = true;
            this.BtnGuardarCodigo.Click += new System.EventHandler(this.BtnGuardarCodigo_Click);
            // 
            // BtnGenerarCodigo
            // 
            this.BtnGenerarCodigo.FlatAppearance.BorderSize = 0;
            this.BtnGenerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarCodigo.Location = new System.Drawing.Point(49, 227);
            this.BtnGenerarCodigo.Name = "BtnGenerarCodigo";
            this.BtnGenerarCodigo.Size = new System.Drawing.Size(109, 35);
            this.BtnGenerarCodigo.TabIndex = 17;
            this.BtnGenerarCodigo.Text = "Generar\r\n";
            this.BtnGenerarCodigo.UseVisualStyleBackColor = true;
            this.BtnGenerarCodigo.Click += new System.EventHandler(this.BtnGenerarCodigo_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigo.Location = new System.Drawing.Point(49, 193);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(282, 28);
            this.TxtCodigo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Codigo de barras(*)";
            // 
            // PicImagen
            // 
            this.PicImagen.Location = new System.Drawing.Point(817, 117);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(184, 123);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 14;
            this.PicImagen.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.FlatAppearance.BorderSize = 0;
            this.BtnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImagen.Image = global::sistema.presentacion.Properties.Resources.imageup_imagen_12892;
            this.BtnCargarImagen.Location = new System.Drawing.Point(994, 46);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(44, 31);
            this.BtnCargarImagen.TabIndex = 13;
            this.BtnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // TxtImagen
            // 
            this.TxtImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtImagen.Enabled = false;
            this.TxtImagen.Location = new System.Drawing.Point(817, 69);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(171, 28);
            this.TxtImagen.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imagen";
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(47, 40);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(282, 37);
            this.CboCategoria.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoría(*)";
            // 
            // btnactualizar
            // 
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Image = global::sistema.presentacion.Properties.Resources.actualizarr;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(254, 431);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(124, 43);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::sistema.presentacion.Properties.Resources.nooooo;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(405, 431);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(133, 43);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderSize = 0;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Image = global::sistema.presentacion.Properties.Resources.database_add_insert_21836;
            this.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsertar.Location = new System.Drawing.Point(268, 431);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(110, 43);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::sistema.presentacion.Properties.Resources.PRODUC;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(427, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 153);
            this.panel1.TabIndex = 24;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // chkseleccionar
            // 
            this.chkseleccionar.AutoSize = true;
            this.chkseleccionar.Location = new System.Drawing.Point(53, 340);
            this.chkseleccionar.Name = "chkseleccionar";
            this.chkseleccionar.Size = new System.Drawing.Size(167, 33);
            this.chkseleccionar.TabIndex = 4;
            this.chkseleccionar.Text = "Seleccionar";
            this.chkseleccionar.UseVisualStyleBackColor = true;
            this.chkseleccionar.CheckedChanged += new System.EventHandler(this.chkseleccionar_CheckedChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Location = new System.Drawing.Point(20, 35);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(253, 28);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(901, 434);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(74, 29);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btndesactivar);
            this.tabPage1.Controls.Add(this.btnactivar);
            this.tabPage1.Controls.Add(this.chkseleccionar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.dgblistado);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::sistema.presentacion.Properties.Resources.eliminar;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(566, 426);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 37);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btndesactivar
            // 
            this.btndesactivar.FlatAppearance.BorderSize = 0;
            this.btndesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesactivar.Image = global::sistema.presentacion.Properties.Resources.cancel_stop_exit_1583;
            this.btndesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndesactivar.Location = new System.Drawing.Point(398, 426);
            this.btndesactivar.Name = "btndesactivar";
            this.btndesactivar.Size = new System.Drawing.Size(140, 37);
            this.btndesactivar.TabIndex = 6;
            this.btndesactivar.Text = "Desactivar";
            this.btndesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndesactivar.UseVisualStyleBackColor = true;
            this.btndesactivar.Click += new System.EventHandler(this.btndesactivar_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.FlatAppearance.BorderSize = 0;
            this.btnactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactivar.Image = global::sistema.presentacion.Properties.Resources.siii;
            this.btnactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactivar.Location = new System.Drawing.Point(278, 426);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(97, 37);
            this.btnactivar.TabIndex = 5;
            this.btnactivar.Text = "Activar";
            this.btnactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::sistema.presentacion.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(278, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(50, 41);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgblistado
            // 
            this.dgblistado.AllowUserToAddRows = false;
            this.dgblistado.AllowUserToDeleteRows = false;
            this.dgblistado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgblistado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgblistado.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgblistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgblistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgblistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgblistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgblistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgblistado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgblistado.Location = new System.Drawing.Point(20, 77);
            this.dgblistado.Name = "dgblistado";
            this.dgblistado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgblistado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgblistado.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgblistado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgblistado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgblistado.RowTemplate.Height = 24;
            this.dgblistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgblistado.Size = new System.Drawing.Size(1202, 239);
            this.dgblistado.TabIndex = 0;
            this.dgblistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellContentClick);
            this.dgblistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellDoubleClick);
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabPage1);
            this.tabgeneral.Controls.Add(this.tabPage2);
            this.tabgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(1, 0);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1236, 536);
            this.tabgeneral.TabIndex = 1;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1249, 546);
            this.Controls.Add(this.tabgeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btndesactivar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.CheckBox chkseleccionar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgblistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Button BtnGuardarCodigo;
        private System.Windows.Forms.Button BtnGenerarCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}