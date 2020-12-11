namespace sistema.presentacion
{
    partial class frmconsulta_ventafechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsulta_ventafechas));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelmostrar = new System.Windows.Forms.Panel();
            this.txtttotal = new System.Windows.Forms.TextBox();
            this.txtiiva = new System.Windows.Forms.TextBox();
            this.txtssubtotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DGVMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgblistado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabgeneral = new System.Windows.Forms.TabControl();
            this.dateinicio = new System.Windows.Forms.DateTimePicker();
            this.datefinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.panelmostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.datefinal);
            this.tabPage1.Controls.Add(this.dateinicio);
            this.tabPage1.Controls.Add(this.BtnReporte);
            this.tabPage1.Controls.Add(this.panelmostrar);
            this.tabPage1.Controls.Add(this.btnbuscar);
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
            this.panelmostrar.Location = new System.Drawing.Point(236, 157);
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
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(694, 449);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 25);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total:";
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
            this.dgblistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabPage1);
            this.tabgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(12, 12);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1211, 619);
            this.tabgeneral.TabIndex = 3;
            // 
            // dateinicio
            // 
            this.dateinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateinicio.Location = new System.Drawing.Point(3, 30);
            this.dateinicio.Name = "dateinicio";
            this.dateinicio.Size = new System.Drawing.Size(133, 30);
            this.dateinicio.TabIndex = 10;
            // 
            // datefinal
            // 
            this.datefinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefinal.Location = new System.Drawing.Point(142, 28);
            this.datefinal.Name = "datefinal";
            this.datefinal.Size = new System.Drawing.Size(133, 30);
            this.datefinal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta";
            // 
            // BtnReporte
            // 
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Image = global::sistema.presentacion.Properties.Resources.business_salesreport_salesreport_negocio_2353;
            this.BtnReporte.Location = new System.Drawing.Point(372, 17);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(50, 41);
            this.BtnReporte.TabIndex = 9;
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
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
            // frmconsulta_ventafechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1353, 705);
            this.Controls.Add(this.tabgeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmconsulta_ventafechas";
            this.Text = "Consulta de ventas por fechas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmconsulta_ventafechas_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelmostrar.ResumeLayout(false);
            this.panelmostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Panel panelmostrar;
        private System.Windows.Forms.TextBox txtttotal;
        private System.Windows.Forms.TextBox txtiiva;
        private System.Windows.Forms.TextBox txtssubtotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVMostrarDetalle;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgblistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datefinal;
        private System.Windows.Forms.DateTimePicker dateinicio;
    }
}