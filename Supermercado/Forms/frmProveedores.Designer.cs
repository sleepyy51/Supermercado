namespace Supermercado.Forms
{
    partial class frmProveedores
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.cmsProveedores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.cmsProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 30);
            this.lblTitulo.Text = "Proveedores";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.lblBuscar.Location = new System.Drawing.Point(32, 85);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 19);
            this.lblBuscar.Text = "Buscar proveedor";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(150, 82);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(330, 25);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(500, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "➕ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                BackColor = System.Drawing.Color.FromArgb(52, 152, 219),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold),
                Padding = new System.Windows.Forms.Padding(5)
            };
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.GridColor = System.Drawing.Color.LightGray;
            this.dgvProveedores.Location = new System.Drawing.Point(35, 130);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(750, 330);
            this.dgvProveedores.TabIndex = 2;
            this.dgvProveedores.ContextMenuStrip = this.cmsProveedores;
            // 
            // cmsProveedores
            // 
            this.cmsProveedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsProveedores.Name = "cmsProveedores";
            this.cmsProveedores.Size = new System.Drawing.Size(132, 52);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmProveedores
            // 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProveedores);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.cmsProveedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ContextMenuStrip cmsProveedores;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
