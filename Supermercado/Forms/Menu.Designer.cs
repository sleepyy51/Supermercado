namespace Supermercado
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Labels
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.labHora = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();

            // Botones
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnDetallesFacturas = new System.Windows.Forms.Button();

            // Timer
            this.tmrHora = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // ===== Form =====
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - Supermercado";

            // ===== lblTitulo =====
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(35, 45, 60);
            this.lblTitulo.Location = new System.Drawing.Point(35, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Bienvenido";

            // ===== lblSubtitulo =====
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 65);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Seleccione una opción para continuar:";

            // ===== Botones =====
            System.Drawing.Size btnSize = new System.Drawing.Size(200, 40);
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 11F);
            System.Drawing.Color btnColor = System.Drawing.Color.FromArgb(66, 133, 244);

            // btnClientes
            this.btnClientes.BackColor = btnColor;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.Font = btnFont;
            this.btnClientes.Location = new System.Drawing.Point(40, 120);
            this.btnClientes.Size = btnSize;
            this.btnClientes.Text = "🧍 Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;

            // btnEmpleados
            this.btnEmpleados.BackColor = btnColor;
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.Font = btnFont;
            this.btnEmpleados.Location = new System.Drawing.Point(40, 170);
            this.btnEmpleados.Size = btnSize;
            this.btnEmpleados.Text = "👷 Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);

            // btnFacturas
            this.btnFacturas.BackColor = btnColor;
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.Font = btnFont;
            this.btnFacturas.Location = new System.Drawing.Point(40, 220);
            this.btnFacturas.Size = btnSize;
            this.btnFacturas.Text = "🧾 Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);

            // btnProductos
            this.btnProductos.BackColor = btnColor;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.Font = btnFont;
            this.btnProductos.Location = new System.Drawing.Point(40, 270);
            this.btnProductos.Size = btnSize;
            this.btnProductos.Text = "📦 Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // btnProveedores
            this.btnProveedores.BackColor = btnColor;
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.Font = btnFont;
            this.btnProveedores.Location = new System.Drawing.Point(40, 320);
            this.btnProveedores.Size = btnSize;
            this.btnProveedores.Text = "🚚 Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);

            // btnVentas
            this.btnVentas.BackColor = btnColor;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.Font = btnFont;
            this.btnVentas.Location = new System.Drawing.Point(40, 370);
            this.btnVentas.Size = btnSize;
            this.btnVentas.Text = "💰 Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // btnDetallesFacturas
            this.btnDetallesFacturas.BackColor = btnColor;
            this.btnDetallesFacturas.ForeColor = System.Drawing.Color.White;
            this.btnDetallesFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallesFacturas.FlatAppearance.BorderSize = 0;
            this.btnDetallesFacturas.Font = btnFont;
            this.btnDetallesFacturas.Location = new System.Drawing.Point(310, 120);
            this.btnDetallesFacturas.Size = btnSize;
            this.btnDetallesFacturas.Text = "📄 Detalles Facturas";
            this.btnDetallesFacturas.UseVisualStyleBackColor = false;

            // btnReporte
            this.btnReporte.BackColor = btnColor;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.Font = btnFont;
            this.btnReporte.Location = new System.Drawing.Point(310, 170);
            this.btnReporte.Size = btnSize;
            this.btnReporte.Text = "📊 Vista Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);

            // ===== Hora y Fecha =====
            this.labHora.AutoSize = true;
            this.labHora.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labHora.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.labHora.Location = new System.Drawing.Point(310, 250);
            this.labHora.Text = "00:00:00";

            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labFecha.ForeColor = System.Drawing.Color.Gray;
            this.labFecha.Location = new System.Drawing.Point(310, 300);
            this.labFecha.Text = "Sin fecha actual";

            // ===== Timer =====
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);

            // ===== Agregar controles =====
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitulo, lblSubtitulo,
                btnClientes, btnEmpleados, btnFacturas, btnProductos, btnProveedores, btnVentas,
                btnDetallesFacturas, btnReporte,
                labHora, labFecha
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnDetallesFacturas;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Timer tmrHora;
    }
}