using System.Drawing;
using System.Windows.Forms;

namespace Tienda.Views
{
    partial class FrmMitienda
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton tool01;
        private ToolStripLabel toolClientes;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tool02;
        private ToolStripLabel toolProveedores;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolProductos;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolVentas;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton3;
        private ToolStripLabel toolFacturas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevasVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTiendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miTiendaToolStripMenuItem
            // 
            this.miTiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.informesVentasToolStripMenuItem,
            this.nuevasVentasToolStripMenuItem1,
            this.categoriasToolStripMenuItem});
            this.miTiendaToolStripMenuItem.Name = "miTiendaToolStripMenuItem";
            this.miTiendaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.miTiendaToolStripMenuItem.Text = "Mi Tienda";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click_1);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click_1);
            // 
            // informesVentasToolStripMenuItem
            // 
            this.informesVentasToolStripMenuItem.Name = "informesVentasToolStripMenuItem";
            this.informesVentasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.informesVentasToolStripMenuItem.Text = "InformesVentas";
            this.informesVentasToolStripMenuItem.Click += new System.EventHandler(this.informesVentasToolStripMenuItem_Click);
            // 
            // nuevasVentasToolStripMenuItem1
            // 
            this.nuevasVentasToolStripMenuItem1.Name = "nuevasVentasToolStripMenuItem1";
            this.nuevasVentasToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.nuevasVentasToolStripMenuItem1.Text = "NuevasVentas";
            this.nuevasVentasToolStripMenuItem1.Click += new System.EventHandler(this.nuevasVentasToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda.Properties.Resources.tienda1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DarkRed;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.metroLabel1.Location = new System.Drawing.Point(84, 444);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(332, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "UAI PROYECYO DAS 2024, DONLEY ETGARD MERLIEN";
            // 
            // FrmMitienda
            // 
            this.ClientSize = new System.Drawing.Size(489, 494);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMitienda";
            this.Text = "Mi Tienda";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem miTiendaToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem informesVentasToolStripMenuItem;
        private ToolStripMenuItem nuevasVentasToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}