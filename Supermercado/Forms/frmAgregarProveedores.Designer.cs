namespace Supermercado.Forms
{
    partial class frmAgregarProveedores
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTelSec = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();

            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtTelSec = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmAgregarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Proveedor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(35, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 30);
            this.lblTitulo.Text = "Agregar Proveedor";
            // 
            // Etiquetas fijas
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmpresa.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmpresa.Location = new System.Drawing.Point(80, 100);
            this.lblEmpresa.Text = "Empresa";

            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProducto.ForeColor = System.Drawing.Color.DimGray;
            this.lblProducto.Location = new System.Drawing.Point(80, 150);
            this.lblProducto.Text = "Tipo de Producto";

            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDireccion.Location = new System.Drawing.Point(80, 200);
            this.lblDireccion.Text = "Dirección";

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefono.Location = new System.Drawing.Point(80, 250);
            this.lblTelefono.Text = "Teléfono Principal";

            this.lblTelSec.AutoSize = true;
            this.lblTelSec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelSec.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelSec.Location = new System.Drawing.Point(80, 300);
            this.lblTelSec.Text = "Teléfono Secundario";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(80, 350);
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // Textboxes fijas
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(260, 97);
            this.txtEmpresa.Size = new System.Drawing.Size(280, 25);

            this.txtProducto.Location = new System.Drawing.Point(260, 147);
            this.txtProducto.Size = new System.Drawing.Size(280, 25);

            this.txtDireccion.Location = new System.Drawing.Point(260, 197);
            this.txtDireccion.Size = new System.Drawing.Size(280, 25);

            this.txtTelefono.Location = new System.Drawing.Point(260, 247);
            this.txtTelefono.Size = new System.Drawing.Size(280, 25);

            this.txtTelSec.Location = new System.Drawing.Point(260, 297);
            this.txtTelSec.Size = new System.Drawing.Size(280, 25);

            this.txtEmail.Location = new System.Drawing.Point(260, 347);
            this.txtEmail.Size = new System.Drawing.Size(280, 25);
            // 
            // Botones fijos
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(350, 430);
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.Text = "✅ Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(490, 430);
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // Agregar controles al formulario
            // 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblTelSec);
            this.Controls.Add(this.lblEmail);

            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtTelSec);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTelSec;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtTelSec;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
