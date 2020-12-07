namespace sistema.presentacion
{
    partial class frmvista_clienteventa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvista_clienteventa));
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgblistado = new System.Windows.Forms.DataGridView();
            this.tabgeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).BeginInit();
            this.tabgeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(858, 382);
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
            this.dgblistado.Location = new System.Drawing.Point(53, 77);
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
            this.dgblistado.Size = new System.Drawing.Size(1108, 257);
            this.dgblistado.TabIndex = 0;
            this.dgblistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgblistado_CellContentClick);
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabPage1);
            this.tabgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgeneral.Location = new System.Drawing.Point(16, 17);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(1338, 507);
            this.tabgeneral.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.dgblistado);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1330, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
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
            // frmvista_clienteventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1371, 537);
            this.Controls.Add(this.tabgeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmvista_clienteventa";
            this.Text = "Seleccione un cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgblistado)).EndInit();
            this.tabgeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgblistado;
        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnbuscar;
    }
}