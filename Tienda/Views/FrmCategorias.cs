using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp.Controllers;
using WinFormsApp.Models;

namespace Tienda
{
    public partial class FrmCategorias : MetroForm
    {
        private CategoriaController _categoriaController;
        public FrmCategorias()
        {
            InitializeComponent();
            _categoriaController = new CategoriaController(); 
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var categorias = _categoriaController.ObtenerCategorias().ToList();
            dgvCategorias.DataSource = categorias;

            // Ocultar la columna "Productos" en el DataGridView
            if (dgvCategorias.Columns.Contains("Productos"))
            {
                dgvCategorias.Columns["Productos"].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var CategoriaNuevo = new Categoria
                {
                    Nombre = txtCategorias.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                };

                _categoriaController.AgregarCategoria(CategoriaNuevo);
                CargarDatos();
                LimpiarCampos();

                MessageBox.Show("Proveedor creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetFullExceptionMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    var CategoriasSeleccionado = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;
                    _categoriaController.EliminarCategoria(CategoriasSeleccionado.Codigo);
                    CargarDatos(); // Recargar los datos después de eliminar
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Selecciona un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex) // Capturar ArgumentException
            {
                // Mostrar el mensaje de error en un MessageBox
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    var CategoriaSeleccionado = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;

                    CategoriaSeleccionado.Nombre = txtCategorias.Text;
                    CategoriaSeleccionado.Descripcion = txtDescripcion.Text;

                    _categoriaController.EditarCategoria(CategoriaSeleccionado);
                    CargarDatos(); // Recargar los datos después de editar
                    LimpiarCampos();
                    MessageBox.Show("Proveedor editado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona un proveedor para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            catch (ArgumentException ex) // Capturar ArgumentException
            {
                // Mostrar el mensaje de error en un MessageBox
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            txtCategorias.Text = string.Empty;
        }

        private string GetFullExceptionMessage(Exception ex)
        {
            string mensaje = ex.Message;
            Exception inner = ex.InnerException;

            while (inner != null)
            {
                mensaje += "\n" + inner.Message;
                inner = inner.InnerException;
            }

            return mensaje;
        }
    }
}
