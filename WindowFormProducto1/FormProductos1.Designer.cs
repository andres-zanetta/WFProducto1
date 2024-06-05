namespace WindowFormProducto1
{
    partial class FormProductos1
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.RIngreso = new System.Windows.Forms.RadioButton();
            this.RSalida = new System.Windows.Forms.RadioButton();
            this.tabCargaDeProducto = new System.Windows.Forms.TabControl();
            this.CargaProducto = new System.Windows.Forms.TabPage();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.textBoxDescrip2 = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.textBoxCod1 = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.MovProducto = new System.Windows.Forms.TabPage();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.lblStockMov = new System.Windows.Forms.Label();
            this.lblDescripcionMov = new System.Windows.Forms.Label();
            this.textBoxCant2 = new System.Windows.Forms.TextBox();
            this.TBoxCod2 = new System.Windows.Forms.TextBox();
            this.lblCanr2 = new System.Windows.Forms.Label();
            this.lblStock2 = new System.Windows.Forms.Label();
            this.lbldescrp2 = new System.Windows.Forms.Label();
            this.lblCod2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ErrorPCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorPDescrip = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCargaDeProducto.SuspendLayout();
            this.CargaProducto.SuspendLayout();
            this.MovProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPDescrip)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(57, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(61, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 1;
            this.lblCod.Text = "Codigo";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(429, 154);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 3;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // RIngreso
            // 
            this.RIngreso.AutoSize = true;
            this.RIngreso.Location = new System.Drawing.Point(673, 70);
            this.RIngreso.Name = "RIngreso";
            this.RIngreso.Size = new System.Drawing.Size(60, 17);
            this.RIngreso.TabIndex = 4;
            this.RIngreso.TabStop = true;
            this.RIngreso.Text = "Ingreso";
            this.RIngreso.UseVisualStyleBackColor = true;
            // 
            // RSalida
            // 
            this.RSalida.AutoSize = true;
            this.RSalida.Location = new System.Drawing.Point(673, 93);
            this.RSalida.Name = "RSalida";
            this.RSalida.Size = new System.Drawing.Size(54, 17);
            this.RSalida.TabIndex = 5;
            this.RSalida.TabStop = true;
            this.RSalida.Text = "Salida";
            this.RSalida.UseVisualStyleBackColor = true;
            // 
            // tabCargaDeProducto
            // 
            this.tabCargaDeProducto.Controls.Add(this.CargaProducto);
            this.tabCargaDeProducto.Controls.Add(this.MovProducto);
            this.tabCargaDeProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCargaDeProducto.Location = new System.Drawing.Point(60, 22);
            this.tabCargaDeProducto.Name = "tabCargaDeProducto";
            this.tabCargaDeProducto.SelectedIndex = 0;
            this.tabCargaDeProducto.Size = new System.Drawing.Size(899, 233);
            this.tabCargaDeProducto.TabIndex = 6;
            // 
            // CargaProducto
            // 
            this.CargaProducto.Controls.Add(this.BtnBorrar);
            this.CargaProducto.Controls.Add(this.textBoxDescrip2);
            this.CargaProducto.Controls.Add(this.BtnBuscar);
            this.CargaProducto.Controls.Add(this.textBoxCod1);
            this.CargaProducto.Controls.Add(this.lblDescrip);
            this.CargaProducto.Controls.Add(this.lblCod);
            this.CargaProducto.Controls.Add(this.BtnCargar);
            this.CargaProducto.Location = new System.Drawing.Point(4, 22);
            this.CargaProducto.Name = "CargaProducto";
            this.CargaProducto.Padding = new System.Windows.Forms.Padding(3);
            this.CargaProducto.Size = new System.Drawing.Size(891, 207);
            this.CargaProducto.TabIndex = 0;
            this.CargaProducto.Text = "tabPage1";
            this.CargaProducto.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(510, 154);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 8;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // textBoxDescrip2
            // 
            this.textBoxDescrip2.Location = new System.Drawing.Point(128, 66);
            this.textBoxDescrip2.Name = "textBoxDescrip2";
            this.textBoxDescrip2.Size = new System.Drawing.Size(166, 20);
            this.textBoxDescrip2.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(348, 154);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // textBoxCod1
            // 
            this.textBoxCod1.Location = new System.Drawing.Point(128, 25);
            this.textBoxCod1.Name = "textBoxCod1";
            this.textBoxCod1.Size = new System.Drawing.Size(166, 20);
            this.textBoxCod1.TabIndex = 4;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(61, 69);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(63, 13);
            this.lblDescrip.TabIndex = 3;
            this.lblDescrip.Text = "Descripcion";
            // 
            // MovProducto
            // 
            this.MovProducto.Controls.Add(this.btnAceptar2);
            this.MovProducto.Controls.Add(this.lblStockMov);
            this.MovProducto.Controls.Add(this.RSalida);
            this.MovProducto.Controls.Add(this.lblDescripcionMov);
            this.MovProducto.Controls.Add(this.RIngreso);
            this.MovProducto.Controls.Add(this.textBoxCant2);
            this.MovProducto.Controls.Add(this.TBoxCod2);
            this.MovProducto.Controls.Add(this.lblCanr2);
            this.MovProducto.Controls.Add(this.lblStock2);
            this.MovProducto.Controls.Add(this.lbldescrp2);
            this.MovProducto.Controls.Add(this.lblCod2);
            this.MovProducto.Location = new System.Drawing.Point(4, 22);
            this.MovProducto.Name = "MovProducto";
            this.MovProducto.Padding = new System.Windows.Forms.Padding(3);
            this.MovProducto.Size = new System.Drawing.Size(891, 207);
            this.MovProducto.TabIndex = 1;
            this.MovProducto.Text = "tabPage2";
            this.MovProducto.UseVisualStyleBackColor = true;
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Location = new System.Drawing.Point(673, 143);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar2.TabIndex = 12;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // lblStockMov
            // 
            this.lblStockMov.AutoSize = true;
            this.lblStockMov.Location = new System.Drawing.Point(187, 97);
            this.lblStockMov.Name = "lblStockMov";
            this.lblStockMov.Size = new System.Drawing.Size(68, 13);
            this.lblStockMov.TabIndex = 11;
            this.lblStockMov.Text = "Stock Actual";
            // 
            // lblDescripcionMov
            // 
            this.lblDescripcionMov.AutoSize = true;
            this.lblDescripcionMov.Location = new System.Drawing.Point(187, 74);
            this.lblDescripcionMov.Name = "lblDescripcionMov";
            this.lblDescripcionMov.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionMov.TabIndex = 10;
            this.lblDescripcionMov.Text = "Descripcion";
            // 
            // textBoxCant2
            // 
            this.textBoxCant2.Location = new System.Drawing.Point(311, 146);
            this.textBoxCant2.Name = "textBoxCant2";
            this.textBoxCant2.Size = new System.Drawing.Size(56, 20);
            this.textBoxCant2.TabIndex = 9;
            // 
            // TBoxCod2
            // 
            this.TBoxCod2.Location = new System.Drawing.Point(187, 45);
            this.TBoxCod2.Name = "TBoxCod2";
            this.TBoxCod2.Size = new System.Drawing.Size(56, 20);
            this.TBoxCod2.TabIndex = 8;
            // 
            // lblCanr2
            // 
            this.lblCanr2.AutoSize = true;
            this.lblCanr2.Location = new System.Drawing.Point(276, 149);
            this.lblCanr2.Name = "lblCanr2";
            this.lblCanr2.Size = new System.Drawing.Size(29, 13);
            this.lblCanr2.TabIndex = 7;
            this.lblCanr2.Text = "Cant";
            // 
            // lblStock2
            // 
            this.lblStock2.AutoSize = true;
            this.lblStock2.Location = new System.Drawing.Point(118, 97);
            this.lblStock2.Name = "lblStock2";
            this.lblStock2.Size = new System.Drawing.Size(35, 13);
            this.lblStock2.TabIndex = 6;
            this.lblStock2.Text = "Stock";
            // 
            // lbldescrp2
            // 
            this.lbldescrp2.AutoSize = true;
            this.lbldescrp2.Location = new System.Drawing.Point(118, 74);
            this.lbldescrp2.Name = "lbldescrp2";
            this.lbldescrp2.Size = new System.Drawing.Size(63, 13);
            this.lbldescrp2.TabIndex = 5;
            this.lbldescrp2.Text = "Descripcion";
            // 
            // lblCod2
            // 
            this.lblCod2.AutoSize = true;
            this.lblCod2.Location = new System.Drawing.Point(118, 45);
            this.lblCod2.Name = "lblCod2";
            this.lblCod2.Size = new System.Drawing.Size(40, 13);
            this.lblCod2.TabIndex = 4;
            this.lblCod2.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // ErrorPCod
            // 
            this.ErrorPCod.ContainerControl = this;
            // 
            // ErrorPDescrip
            // 
            this.ErrorPDescrip.ContainerControl = this;
            // 
            // FormProductos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabCargaDeProducto);
            this.Controls.Add(this.lbl);
            this.Name = "FormProductos1";
            this.Text = "FormProductos1";
            this.tabCargaDeProducto.ResumeLayout(false);
            this.CargaProducto.ResumeLayout(false);
            this.CargaProducto.PerformLayout();
            this.MovProducto.ResumeLayout(false);
            this.MovProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPDescrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.RadioButton RIngreso;
        private System.Windows.Forms.RadioButton RSalida;
        private System.Windows.Forms.TabControl tabCargaDeProducto;
        private System.Windows.Forms.TabPage CargaProducto;
        private System.Windows.Forms.TabPage MovProducto;
        private System.Windows.Forms.Label lblCod2;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox textBoxDescrip2;
        private System.Windows.Forms.TextBox textBoxCod1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label lblStock2;
        private System.Windows.Forms.Label lbldescrp2;
        private System.Windows.Forms.Label lblCanr2;
        private System.Windows.Forms.Label lblStockMov;
        private System.Windows.Forms.Label lblDescripcionMov;
        private System.Windows.Forms.TextBox textBoxCant2;
        private System.Windows.Forms.TextBox TBoxCod2;
        private System.Windows.Forms.Button btnAceptar2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider ErrorPCod;
        private System.Windows.Forms.ErrorProvider ErrorPDescrip;
    }
}