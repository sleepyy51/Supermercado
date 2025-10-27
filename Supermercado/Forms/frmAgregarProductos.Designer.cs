namespace Supermercado.Forms
{
    partial class frmAgregarProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Productos";
            // 
            // label1
            // 
            this.label1.Text = "Registro de Productos";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(45, 75, 150);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.AutoSize = true;
            // 
            // label2
            // 
            this.label2.Text = "Proveedor:";
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.AutoSize = true;
            // 
            // cbProveedor
            // 
            this.cbProveedor.Location = new System.Drawing.Point(110, 67);
            this.cbProveedor.Size = new System.Drawing.Size(150, 23);
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // label3
            // 
            this.label3.Text = "Código:";
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.AutoSize = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 107);
            this.txtCodigo.Size = new System.Drawing.Size(150, 23);
            // 
            // label5
            // 
            this.label5.Text = "Nombre:";
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.AutoSize = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 147);
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            // 
            // label6
            // 
            this.label6.Text = "Marca:";
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.AutoSize = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(110, 187);
            this.txtMarca.Size = new System.Drawing.Size(150, 23);
            // 
            // label7
            // 
            this.label7.Text = "Tipo:";
            this.label7.Location = new System.Drawing.Point(25, 230);
            this.label7.AutoSize = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(110, 227);
            this.txtTipo.Size = new System.Drawing.Size(150, 23);
            // 
            // label8
            // 
            this.label8.Text = "Grupo:";
            this.label8.Location = new System.Drawing.Point(25, 270);
            this.label8.AutoSize = true;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(110, 267);
            this.txtGrupo.Size = new System.Drawing.Size(150, 23);
            // 
            // label10
            // 
            this.label10.Text = "Peso:";
            this.label10.Location = new System.Drawing.Point(300, 70);
            this.label10.AutoSize = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(400, 67);
            this.txtPeso.Size = new System.Drawing.Size(120, 23);
            // 
            // label11
            // 
            this.label11.Text = "Stock:";
            this.label11.Location = new System.Drawing.Point(300, 110);
            this.label11.AutoSize = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(400, 107);
            this.txtStock.Size = new System.Drawing.Size(120, 23);
            // 
            // label9
            // 
            this.label9.Text = "Precio Unidad:";
            this.label9.Location = new System.Drawing.Point(300, 150);
            this.label9.AutoSize = true;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(400, 147);
            this.txtPrecioUnidad.Size = new System.Drawing.Size(120, 23);
            // 
            // label4
            // 
            this.label4.Text = "Imagen:";
            this.label4.Location = new System.Drawing.Point(300, 190);
            this.label4.AutoSize = true;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(400, 187);
            this.txtImagen.Size = new System.Drawing.Size(200, 23);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(400, 220);
            this.pbImagen.Size = new System.Drawing.Size(200, 120);
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(60, 140, 200);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(400, 360);
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(510, 360);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Controls
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);

            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7,
            label8, label9, label10, label11;
        private System.Windows.Forms.TextBox txtCodigo, txtNombre, txtMarca, txtTipo,
            txtGrupo, txtPeso, txtStock, txtPrecioUnidad, txtImagen;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnAgregar, btnCancelar;
    }
}
