namespace ProgIIIListas
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
            this.BtSalir = new System.Windows.Forms.Button();
            this.DvDatos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtCargar = new System.Windows.Forms.Button();
            this.LbReg = new System.Windows.Forms.Label();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.TxArticulo = new System.Windows.Forms.TextBox();
            this.TxCantidad = new System.Windows.Forms.TextBox();
            this.TxLimite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtActualizar = new System.Windows.Forms.Button();
            this.BtBorrar = new System.Windows.Forms.Button();
            this.BtOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(480, 237);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 23);
            this.BtSalir.TabIndex = 0;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // DvDatos
            // 
            this.DvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Codigo,
            this.Cantidad,
            this.Precio,
            this.Valor_total});
            this.DvDatos.Location = new System.Drawing.Point(12, 60);
            this.DvDatos.Name = "DvDatos";
            this.DvDatos.Size = new System.Drawing.Size(543, 171);
            this.DvDatos.TabIndex = 1;
            this.DvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvDatos_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Valor_total
            // 
            this.Valor_total.HeaderText = "Valor Total";
            this.Valor_total.Name = "Valor_total";
            // 
            // BtCargar
            // 
            this.BtCargar.Location = new System.Drawing.Point(386, 237);
            this.BtCargar.Name = "BtCargar";
            this.BtCargar.Size = new System.Drawing.Size(75, 23);
            this.BtCargar.TabIndex = 2;
            this.BtCargar.Text = "Cargar";
            this.BtCargar.UseVisualStyleBackColor = true;
            this.BtCargar.Click += new System.EventHandler(this.BtCargar_Click);
            // 
            // LbReg
            // 
            this.LbReg.AutoSize = true;
            this.LbReg.Location = new System.Drawing.Point(9, 262);
            this.LbReg.Name = "LbReg";
            this.LbReg.Size = new System.Drawing.Size(36, 13);
            this.LbReg.TabIndex = 3;
            this.LbReg.Text = "Indice";
            // 
            // TxCodigo
            // 
            this.TxCodigo.Location = new System.Drawing.Point(69, 318);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(185, 20);
            this.TxCodigo.TabIndex = 4;
            // 
            // TxArticulo
            // 
            this.TxArticulo.Location = new System.Drawing.Point(69, 288);
            this.TxArticulo.Name = "TxArticulo";
            this.TxArticulo.Size = new System.Drawing.Size(185, 20);
            this.TxArticulo.TabIndex = 5;
            // 
            // TxCantidad
            // 
            this.TxCantidad.Location = new System.Drawing.Point(69, 344);
            this.TxCantidad.Name = "TxCantidad";
            this.TxCantidad.Size = new System.Drawing.Size(185, 20);
            this.TxCantidad.TabIndex = 6;
            // 
            // TxLimite
            // 
            this.TxLimite.Location = new System.Drawing.Point(69, 370);
            this.TxLimite.Name = "TxLimite";
            this.TxLimite.Size = new System.Drawing.Size(185, 20);
            this.TxLimite.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Limite";
            // 
            // BtActualizar
            // 
            this.BtActualizar.Enabled = false;
            this.BtActualizar.Location = new System.Drawing.Point(480, 291);
            this.BtActualizar.Name = "BtActualizar";
            this.BtActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtActualizar.TabIndex = 12;
            this.BtActualizar.Text = "Actualizar";
            this.BtActualizar.UseVisualStyleBackColor = true;
            this.BtActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.Enabled = false;
            this.BtBorrar.Location = new System.Drawing.Point(480, 321);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtBorrar.TabIndex = 13;
            this.BtBorrar.Text = "Borrar";
            this.BtBorrar.UseVisualStyleBackColor = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // BtOrdenar
            // 
            this.BtOrdenar.Enabled = false;
            this.BtOrdenar.Location = new System.Drawing.Point(480, 350);
            this.BtOrdenar.Name = "BtOrdenar";
            this.BtOrdenar.Size = new System.Drawing.Size(75, 23);
            this.BtOrdenar.TabIndex = 14;
            this.BtOrdenar.Text = "Ordenar 5";
            this.BtOrdenar.UseVisualStyleBackColor = true;
            this.BtOrdenar.Click += new System.EventHandler(this.BtOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 468);
            this.Controls.Add(this.BtOrdenar);
            this.Controls.Add(this.BtBorrar);
            this.Controls.Add(this.BtActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxLimite);
            this.Controls.Add(this.TxCantidad);
            this.Controls.Add(this.TxArticulo);
            this.Controls.Add(this.TxCodigo);
            this.Controls.Add(this.LbReg);
            this.Controls.Add(this.BtCargar);
            this.Controls.Add(this.DvDatos);
            this.Controls.Add(this.BtSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.DataGridView DvDatos;
        private System.Windows.Forms.Button BtCargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_total;
        private System.Windows.Forms.Label LbReg;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.TextBox TxArticulo;
        private System.Windows.Forms.TextBox TxCantidad;
        private System.Windows.Forms.TextBox TxLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtActualizar;
        private System.Windows.Forms.Button BtBorrar;
        private System.Windows.Forms.Button BtOrdenar;
    }
}

