using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace Tienda.Views
{
    public partial class FrmMitienda : MetroForm
    {
        public FrmMitienda()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Proveedores formProveedor = new Proveedores();
            formProveedor.ShowDialog();
        }

        private void informesVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturas formInforme = new FormFacturas();
            formInforme.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void nuevasVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FormFacturas formInforme = new FormFacturas();
            formInforme.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }
    }
}
