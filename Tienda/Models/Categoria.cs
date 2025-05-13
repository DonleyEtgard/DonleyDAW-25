using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace WinFormsApp.Models
{
    public class Categoria
    {
        [Key]  // Marca esta propiedad como la clave primaria
        public int Codigo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public static void Agregar(AppDbContext context, Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
        }

        public static void Editar(AppDbContext context, Categoria categoria)
        {
            var CategoriaExistente = context.Categorias.FirstOrDefault(p => p.Codigo == categoria.Codigo);
            if (CategoriaExistente != null)
            {
                CategoriaExistente.Nombre = categoria.Nombre;
                CategoriaExistente.Descripcion = categoria.Descripcion;
                context.SaveChanges();
            }
        }

        public static void Eliminar(AppDbContext context, int codigo)
        {
            var categoria = context.Categorias.FirstOrDefault(p => p.Codigo == codigo);
            if (categoria != null)
            {
                context.Categorias.Remove(categoria);
                context.SaveChanges();
            }
        }

        public static IQueryable<Categoria> ObtenerCategria(AppDbContext context)
        {
            return context.Categorias.Include("Productos");
        }

        public static Categoria ObtenerProveedor(AppDbContext context, int codigo)
        {
            return context.Categorias.FirstOrDefault(p => p.Codigo == codigo);
        }
    }
}

