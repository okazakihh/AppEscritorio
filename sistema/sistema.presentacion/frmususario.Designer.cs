namespace sistema.presentacion
{
    partial class frmususario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmususario));
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btninsertar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btndesactivar = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.chkseleccionar = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgblistado = new System.Windows.Forms.DataGridView();
            this.tabgeneral = new System.Windows.Forms.TabControl();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumDocumento = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnactualizar
            // 
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Image = global::sistema.presentacion.Properties.Resources.actualizarr;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(93, 422);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(130, 43);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(257, 7);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(57, 28);
            this.txtid.TabIndex = 4;
            this.txtid.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Location = new System.Drawing.Point(247, 148);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(244, 28);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::sistema.presentacion.Properties.Resources.nooooo;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(277, 422);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(156, 43);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CboTipoDocumento);
            this.tabPage2.Controls.Add(this.TxtTelefono);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtDireccion);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtNumDocumento);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CboRol);
            this.tabPage2.Controls.Add(this.btnactualizar);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btncancelar);
            this.tabPage2.Controls.Add(this.btninsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderSize = 0;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Image = global::sistema.presentacion.Properties.Resources.database_add_insert_21836;
            this.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsertar.Location = new System.Drawing.Point(99, 422);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(124, 43);
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
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::sistema.presentacion.Properties.Resources.eliminar;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(544, 378);
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
            this.btndesactivar.Location = new System.Drawing.Point(393, 378);
            this.btndesactivar.Name = "btndesactivar";
            this.btndesactivar.Size = new System.Drawing.Size(123, 37);
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
            this.btnactivar.Location = new System.Drawing.Point(256, 378);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(97, 37);
            this.btnactivar.TabIndex = 5;
            this.btnactivar.Text = "Activar";
            this.btnactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // chkseleccionar
            // 
            this.chkseleccionar.AutoSize = true;
            this.chkseleccionar.Location = new System.Drawing.Point(36, 378);
            this.chkseleccionar.Name = "chkseleccionar";
            this.chkseleccionar.Size = new System.Drawing.Size(167, 33);
            this.chkseleccionar.TabIndex = 4;
            this.chkseleccionar.Text = "Seleccionar";
            this.chkseleccionar.UseVisualStyleBackColor = true;
            this.chkseleccionar.CheckedChanged += new System.EventHandler(this.chkseleccionar_CheckedChanged);
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
            this.lbltotal.Location = new System.Drawing.Point(858, 382);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
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
            this.dgblistado.Location = new System.Drawing.Point(53, 77);
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
            this.dgblistado.Size = new System.Drawing.Size(1108, 257);
            this.dgblistado.TabIndex = 0;
            this.dgblistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellContentClick);
            this.dgblistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellDoubleClick);
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabPage1);
            this.tabgeneral.Controls.Add(this.tabPage2);
            this.tabgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(3, 0);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1283, 555);
            this.tabgeneral.TabIndex = 1;
            // 
            // CboRol
            // 
            this.CboRol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Location = new System.Drawing.Point(247, 64);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(244, 34);
            this.CboRol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol ";
            // 
            // TxtNumDocumento
            // 
            this.TxtNumDocumento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumDocumento.Location = new System.Drawing.Point(248, 297);
            this.TxtNumDocumento.Name = "TxtNumDocumento";
            this.TxtNumDocumento.Size = new System.Drawing.Size(245, 28);
            this.TxtNumDocumento.TabIndex = 14;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDireccion.Location = new System.Drawing.Point(249, 358);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(244, 28);
            this.TxtDireccion.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dirección ";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTelefono.Location = new System.Drawing.Point(666, 70);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(244, 28);
            this.TxtTelefono.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Teléfono";
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Items.AddRange(new object[] {
            "Cédula",
            "Cedula extrangera",
            "Passaporte",
            "Nit"});
            this.CboTipoDocumento.Location = new System.Drawing.Point(248, 218);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(245, 34);
            this.CboTipoDocumento.TabIndex = 19;
            this.CboTipoDocumento.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Numero de documento ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtClave);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(618, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 300);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Contreaseña(A)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(571, 66);
            this.label10.TabIndex = 2;
            this.label10.Text = "A: Para ingresar un nuevo usuario el campo contraseña es obligatorio,\r\npero para " +
    "actualizar un usuario deje el campo contraseña en blanco\r\na menos que desee modi" +
    "ficar la contraseña";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Location = new System.Drawing.Point(98, 70);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(277, 28);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtClave.Location = new System.Drawing.Point(98, 157);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(277, 28);
            this.TxtClave.TabIndex = 4;
            // 
            // frmususario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1315, 567);
            this.Controls.Add(this.tabgeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmususario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmususario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboRol;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNumDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}