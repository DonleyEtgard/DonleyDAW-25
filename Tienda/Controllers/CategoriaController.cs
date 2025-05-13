using System.Linq;
using Microsoft.EntityFrameworkCore;
using WinFormsApp.Models;

namespace WinFormsApp.Controllers
{
    public class CategoriaController
    {
        private readonly AppDbContext _context;

        public CategoriaController()
        {
            _context = new AppDbContext();
        }

        // Agregar nueva categoría
        public void AgregarCategoria(Categoria categoria)
        {
            if (categoria != null)
            {
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
            }
        }

        // Editar una categoría existente
        public void EditarCategoria(Categoria categoria)
        {
            var categoriaExistente = _context.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
            if (categoriaExistente != null)
            {
                categoriaExistente.Nombre = categoria.Nombre;
                categoriaExistente.Descripcion = categoria.Descripcion;
                _context.SaveChanges();
            }
        }

        // Eliminar categoría por código
        public void EliminarCategoria(int codigo)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Codigo == codigo);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
            }
        }

        // Obtener todas las categorías
        public IQueryable<Categoria> ObtenerCategorias()
        {
            return _context.Categorias.AsNoTracking();
        }

        // Obtener una sola categoría por código
        public Categoria ObtenerCategoria(int codigo)
        {
            return _context.Categorias.AsNoTracking().FirstOrDefault(c => c.Codigo == codigo);
        }
    }
}