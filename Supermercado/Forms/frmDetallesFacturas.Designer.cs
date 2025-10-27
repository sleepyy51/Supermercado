namespace Supermercado.Forms
{
    partial class frmDetallesFacturas
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
            this.dgvDetallesFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.csmDetalllesFac = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFacturas)).BeginInit();
            this.csmDetalllesFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmDetallesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetallesFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 80);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles de Facturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(90, 82);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 25);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvDetallesFacturas
            // 
            this.dgvDetallesFacturas.AllowUserToAddRows = false;
            this.dgvDetallesFacturas.AllowUserToDeleteRows = false;
            this.dgvDetallesFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetallesFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetallesFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetallesFacturas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.dgvDetallesFacturas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetallesFacturas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDetallesFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFacturas.ContextMenuStrip = this.csmDetalllesFac;
            this.dgvDetallesFacturas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetallesFacturas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.dgvDetallesFacturas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetallesFacturas.GridColor = System.Drawing.Color.LightGray;
            this.dgvDetallesFacturas.Location = new System.Drawing.Point(36, 130);
            this.dgvDetallesFacturas.Name = "dgvDetallesFacturas";
            this.dgvDetallesFacturas.ReadOnly = true;
            this.dgvDetallesFacturas.Size = new System.Drawing.Size(740, 300);
            this.dgvDetallesFacturas.TabIndex = 0;
            // 
            // csmDetalllesFac
            // 
            this.csmDetalllesFac.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.editarToolStripMenuItem,
        this.eliminarToolStripMenuItem});
            this.csmDetalllesFac.Name = "csmDetalllesFac";
            this.csmDetalllesFac.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmDetallesFacturas Controls
            // 
            this.Controls.Add(this.dgvDetallesFacturas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFacturas)).EndInit();
            this.csmDetalllesFac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvDetallesFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip csmDetalllesFac;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}