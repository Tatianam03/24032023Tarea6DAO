using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5BasedeDatos.Models;

namespace Tarea5BasedeDatos.DAO
{
    public class CrudProductos
    {
        public void guardar(Producto paramProducto)
        {
            using(AlmacenContext bd = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = paramProducto.Nombre;
                producto.Descripcion = paramProducto.Descripcion;
                producto.Precio = paramProducto.Precio;
                producto.Stock = paramProducto.Stock;
                bd.Add(producto);
                bd.SaveChanges();
                Console.WriteLine("¡Su producto a sido ingresado correctamente!");
            }
        }
    }
}
