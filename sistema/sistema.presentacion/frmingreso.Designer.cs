﻿namespace sistema.presentacion
{
    partial class frmingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingreso));
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Detalle = new System.Windows.Forms.GroupBox();
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.BtnCerrarArticulos = new System.Windows.Forms.Button();
            this.BtnFiltrarArticulos = new System.Windows.Forms.Button();
            this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnVerArticulo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarr = new System.Windows.Forms.Button();
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.TxtNumComprobante = new System.Windows.Forms.TextBox();
            this.TxtSerieComprobante = new System.Windows.Forms.TextBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkseleccionar = new System.Windows.Forms.CheckBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelmostrar = new System.Windows.Forms.Panel();
            this.txtttotal = new System.Windows.Forms.TextBox();
            this.txtiiva = new System.Windows.Forms.TextBox();
            this.txtssubtotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DGVMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.btnanular = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgblistado = new System.Windows.Forms.DataGridView();
            this.tabgeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Detalle.SuspendLayout();
            this.panelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelmostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(158, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(57, 23);
            this.txtid.TabIndex = 4;
            this.txtid.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.Detalle);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btncancelar);
            this.tabPage2.Controls.Add(this.btninsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1203, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // Detalle
            // 
            this.Detalle.Controls.Add(this.panelArticulos);
            this.Detalle.Controls.Add(this.BtnVerArticulo);
            this.Detalle.Controls.Add(this.label10);
            this.Detalle.Controls.Add(this.TxtTotal);
            this.Detalle.Controls.Add(this.dgvdetalle);
            this.Detalle.Controls.Add(this.label9);
            this.Detalle.Controls.Add(this.label7);
            this.Detalle.Controls.Add(this.TxtIva);
            this.Detalle.Controls.Add(this.Articulo);
            this.Detalle.Controls.Add(this.TxtSubtotal);
            this.Detalle.Controls.Add(this.TxtCodigo);
            this.Detalle.Controls.Add(this.button1);
            this.Detalle.Location = new System.Drawing.Point(-4, 159);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(1175, 367);
            this.Detalle.TabIndex = 8;
            this.Detalle.TabStop = false;
            this.Detalle.Text = "Detalle";
            // 
            // panelArticulos
            // 
            this.panelArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelArticulos.Controls.Add(this.DgvArticulos);
            this.panelArticulos.Controls.Add(this.LblTotalArticulos);
            this.panelArticulos.Controls.Add(this.BtnCerrarArticulos);
            this.panelArticulos.Controls.Add(this.BtnFiltrarArticulos);
            this.panelArticulos.Controls.Add(this.TxtBuscarArticulo);
            this.panelArticulos.Controls.Add(this.label6);
            this.panelArticulos.Location = new System.Drawing.Point(46, 76);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.Size = new System.Drawing.Size(1092, 340);
            this.panelArticulos.TabIndex = 27;
            this.panelArticulos.Visible = false;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(25, 82);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.RowHeadersWidth = 62;
            this.DgvArticulos.RowTemplate.Height = 28;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(1031, 218);
            this.DgvArticulos.TabIndex = 29;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick_1);
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Location = new System.Drawing.Point(870, 303);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(56, 25);
            this.LblTotalArticulos.TabIndex = 28;
            this.LblTotalArticulos.Text = "Total";
            // 
            // BtnCerrarArticulos
            // 
            this.BtnCerrarArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCerrarArticulos.FlatAppearance.BorderSize = 0;
            this.BtnCerrarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarArticulos.Image = global::sistema.presentacion.Properties.Resources.nooooo;
            this.BtnCerrarArticulos.Location = new System.Drawing.Point(1030, 15);
            this.BtnCerrarArticulos.Name = "BtnCerrarArticulos";
            this.BtnCerrarArticulos.Size = new System.Drawing.Size(48, 42);
            this.BtnCerrarArticulos.TabIndex = 27;
            this.BtnCerrarArticulos.UseVisualStyleBackColor = false;
            this.BtnCerrarArticulos.Click += new System.EventHandler(this.BtnCerrarArticulos_Click_1);
            // 
            // BtnFiltrarArticulos
            // 
            this.BtnFiltrarArticulos.FlatAppearance.BorderSize = 0;
            this.BtnFiltrarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarArticulos.Image = global::sistema.presentacion.Properties.Resources.buscar;
            this.BtnFiltrarArticulos.Location = new System.Drawing.Point(362, 23);
            this.BtnFiltrarArticulos.Name = "BtnFiltrarArticulos";
            this.BtnFiltrarArticulos.Size = new System.Drawing.Size(43, 38);
            this.BtnFiltrarArticulos.TabIndex = 26;
            this.BtnFiltrarArticulos.UseVisualStyleBackColor = true;
            this.BtnFiltrarArticulos.Click += new System.EventHandler(this.BtnFiltrarArticulos_Click_1);
            // 
            // TxtBuscarArticulo
            // 
            this.TxtBuscarArticulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarArticulo.Location = new System.Drawing.Point(100, 27);
            this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
            this.TxtBuscarArticulo.Size = new System.Drawing.Size(246, 23);
            this.TxtBuscarArticulo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buscar";
            // 
            // BtnVerArticulo
            // 
            this.BtnVerArticulo.FlatAppearance.BorderSize = 0;
            this.BtnVerArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerArticulo.Image = global::sistema.presentacion.Properties.Resources.buscar;
            this.BtnVerArticulo.Location = new System.Drawing.Point(352, 29);
            this.BtnVerArticulo.Name = "BtnVerArticulo";
            this.BtnVerArticulo.Size = new System.Drawing.Size(43, 38);
            this.BtnVerArticulo.TabIndex = 17;
            this.BtnVerArticulo.UseVisualStyleBackColor = true;
            this.BtnVerArticulo.Click += new System.EventHandler(this.BtnVerArticulo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(865, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtTotal.Location = new System.Drawing.Point(942, 304);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(196, 23);
            this.TxtTotal.TabIndex = 23;
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvdetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(19, 73);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.RowHeadersWidth = 62;
            this.dgvdetalle.RowTemplate.Height = 28;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.Size = new System.Drawing.Size(804, 256);
            this.dgvdetalle.TabIndex = 22;
            this.dgvdetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellEndEdit);
            this.dgvdetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvdetalle_RowsRemoved);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Iva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subtotal";
            // 
            // TxtIva
            // 
            this.TxtIva.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIva.Enabled = false;
            this.TxtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIva.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtIva.Location = new System.Drawing.Point(942, 272);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(182, 23);
            this.TxtIva.TabIndex = 19;
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Location = new System.Drawing.Point(14, 33);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(77, 25);
            this.Articulo.TabIndex = 17;
            this.Articulo.Text = "Articulo";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtSubtotal.Location = new System.Drawing.Point(942, 237);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(182, 23);
            this.TxtSubtotal.TabIndex = 18;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigo.Location = new System.Drawing.Point(91, 34);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(255, 23);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::sistema.presentacion.Properties.Resources.actualizarr;
            this.button1.Location = new System.Drawing.Point(428, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 47);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarr);
            this.groupBox1.Controls.Add(this.CboComprobante);
            this.groupBox1.Controls.Add(this.TxtImpuesto);
            this.groupBox1.Controls.Add(this.TxtNumComprobante);
            this.groupBox1.Controls.Add(this.TxtSerieComprobante);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.TxtIdProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // BtnBuscarr
            // 
            this.BtnBuscarr.FlatAppearance.BorderSize = 0;
            this.BtnBuscarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarr.Image = global::sistema.presentacion.Properties.Resources.buscar;
            this.BtnBuscarr.Location = new System.Drawing.Point(11, 54);
            this.BtnBuscarr.Name = "BtnBuscarr";
            this.BtnBuscarr.Size = new System.Drawing.Size(43, 38);
            this.BtnBuscarr.TabIndex = 16;
            this.BtnBuscarr.UseVisualStyleBackColor = true;
            this.BtnBuscarr.Click += new System.EventHandler(this.BtnBuscarr_Click);
            // 
            // CboComprobante
            // 
            this.CboComprobante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CboComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboComprobante.FormattingEnabled = true;
            this.CboComprobante.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "REMISION",
            "TICKET"});
            this.CboComprobante.Location = new System.Drawing.Point(8, 120);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.Size = new System.Drawing.Size(194, 28);
            this.CboComprobante.TabIndex = 15;
            this.CboComprobante.Text = "FACTURA";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtImpuesto.Location = new System.Drawing.Point(680, 123);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(151, 23);
            this.TxtImpuesto.TabIndex = 14;
            this.TxtImpuesto.Text = "0.19";
            // 
            // TxtNumComprobante
            // 
            this.TxtNumComprobante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNumComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumComprobante.Location = new System.Drawing.Point(424, 123);
            this.TxtNumComprobante.Name = "TxtNumComprobante";
            this.TxtNumComprobante.Size = new System.Drawing.Size(151, 23);
            this.TxtNumComprobante.TabIndex = 13;
            // 
            // TxtSerieComprobante
            // 
            this.TxtSerieComprobante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSerieComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSerieComprobante.Location = new System.Drawing.Point(234, 123);
            this.TxtSerieComprobante.Name = "TxtSerieComprobante";
            this.TxtSerieComprobante.Size = new System.Drawing.Size(151, 23);
            this.TxtSerieComprobante.TabIndex = 12;
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreProveedor.Enabled = false;
            this.TxtNombreProveedor.Location = new System.Drawing.Point(186, 69);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(306, 23);
            this.TxtNombreProveedor.TabIndex = 11;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdProveedor.Enabled = false;
            this.TxtIdProveedor.Location = new System.Drawing.Point(60, 69);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(120, 23);
            this.TxtIdProveedor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proveedor";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::sistema.presentacion.Properties.Resources.nooooo;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(271, 532);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(148, 43);
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
            this.btninsertar.Location = new System.Drawing.Point(114, 532);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(117, 43);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
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
            this.chkseleccionar.Location = new System.Drawing.Point(53, 449);
            this.chkseleccionar.Name = "chkseleccionar";
            this.chkseleccionar.Size = new System.Drawing.Size(141, 29);
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
            this.txtbuscar.Size = new System.Drawing.Size(253, 23);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(694, 449);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 25);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.panelmostrar);
            this.tabPage1.Controls.Add(this.btnanular);
            this.tabPage1.Controls.Add(this.chkseleccionar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.dgblistado);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // panelmostrar
            // 
            this.panelmostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelmostrar.Controls.Add(this.txtttotal);
            this.panelmostrar.Controls.Add(this.txtiiva);
            this.panelmostrar.Controls.Add(this.txtssubtotal);
            this.panelmostrar.Controls.Add(this.label20);
            this.panelmostrar.Controls.Add(this.label11);
            this.panelmostrar.Controls.Add(this.label8);
            this.panelmostrar.Controls.Add(this.DGVMostrarDetalle);
            this.panelmostrar.Controls.Add(this.BtnCerrarDetalle);
            this.panelmostrar.Location = new System.Drawing.Point(226, 223);
            this.panelmostrar.Name = "panelmostrar";
            this.panelmostrar.Size = new System.Drawing.Size(971, 317);
            this.panelmostrar.TabIndex = 7;
            this.panelmostrar.Visible = false;
            // 
            // txtttotal
            // 
            this.txtttotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtttotal.Enabled = false;
            this.txtttotal.Location = new System.Drawing.Point(823, 276);
            this.txtttotal.Name = "txtttotal";
            this.txtttotal.Size = new System.Drawing.Size(127, 23);
            this.txtttotal.TabIndex = 35;
            // 
            // txtiiva
            // 
            this.txtiiva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtiiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtiiva.Enabled = false;
            this.txtiiva.Location = new System.Drawing.Point(823, 236);
            this.txtiiva.Name = "txtiiva";
            this.txtiiva.Size = new System.Drawing.Size(127, 23);
            this.txtiiva.TabIndex = 34;
            // 
            // txtssubtotal
            // 
            this.txtssubtotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtssubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtssubtotal.Enabled = false;
            this.txtssubtotal.Location = new System.Drawing.Point(823, 191);
            this.txtssubtotal.Name = "txtssubtotal";
            this.txtssubtotal.Size = new System.Drawing.Size(127, 23);
            this.txtssubtotal.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(761, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 25);
            this.label20.TabIndex = 32;
            this.label20.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(779, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Iva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(733, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Subtotal";
            // 
            // DGVMostrarDetalle
            // 
            this.DGVMostrarDetalle.AllowUserToAddRows = false;
            this.DGVMostrarDetalle.AllowUserToDeleteRows = false;
            this.DGVMostrarDetalle.AllowUserToOrderColumns = true;
            this.DGVMostrarDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVMostrarDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMostrarDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMostrarDetalle.Location = new System.Drawing.Point(3, 28);
            this.DGVMostrarDetalle.Name = "DGVMostrarDetalle";
            this.DGVMostrarDetalle.ReadOnly = true;
            this.DGVMostrarDetalle.RowHeadersWidth = 62;
            this.DGVMostrarDetalle.RowTemplate.Height = 28;
            this.DGVMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMostrarDetalle.Size = new System.Drawing.Size(724, 253);
            this.DGVMostrarDetalle.TabIndex = 29;
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCerrarDetalle.FlatAppearance.BorderSize = 0;
            this.BtnCerrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarDetalle.Image = global::sistema.presentacion.Properties.Resources.nooooo;
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(907, 13);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(48, 42);
            this.BtnCerrarDetalle.TabIndex = 28;
            this.BtnCerrarDetalle.UseVisualStyleBackColor = false;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // btnanular
            // 
            this.btnanular.FlatAppearance.BorderSize = 0;
            this.btnanular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanular.Image = global::sistema.presentacion.Properties.Resources.cancel_stop_exit_1583;
            this.btnanular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanular.Location = new System.Drawing.Point(393, 449);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(151, 37);
            this.btnanular.TabIndex = 6;
            this.btnanular.Text = "Anular";
            this.btnanular.UseVisualStyleBackColor = true;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::sistema.presentacion.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(294, 19);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgblistado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgblistado.Location = new System.Drawing.Point(0, 66);
            this.dgblistado.Name = "dgblistado";
            this.dgblistado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgblistado.Size = new System.Drawing.Size(1191, 330);
            this.dgblistado.TabIndex = 0;
            this.dgblistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellContentClick);
            this.dgblistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellDoubleClick);
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabPage1);
            this.tabgeneral.Controls.Add(this.tabPage2);
            this.tabgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(2, 3);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1211, 619);
            this.tabgeneral.TabIndex = 1;
            // 
            // frmingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1225, 634);
            this.Controls.Add(this.tabgeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmingreso";
            this.Text = "Ingresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Detalle.ResumeLayout(false);
            this.Detalle.PerformLayout();
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelmostrar.ResumeLayout(false);
            this.panelmostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.CheckBox chkseleccionar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgblistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarr;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.TextBox TxtNumComprobante;
        private System.Windows.Forms.TextBox TxtSerieComprobante;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Detalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Articulo;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnVerArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Panel panelArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.Button BtnCerrarArticulos;
        private System.Windows.Forms.Button BtnFiltrarArticulos;
        private System.Windows.Forms.TextBox TxtBuscarArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelmostrar;
        private System.Windows.Forms.TextBox txtttotal;
        private System.Windows.Forms.TextBox txtiiva;
        private System.Windows.Forms.TextBox txtssubtotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVMostrarDetalle;
        private System.Windows.Forms.Button BtnCerrarDetalle;
    }
}