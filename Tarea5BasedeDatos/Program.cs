using System;
using Tarea5BasedeDatos;
using Tarea5BasedeDatos.DAO;
using Tarea5BasedeDatos.Models;

while (true)
{
    Console.WriteLine("Seleccione una opcion del menu");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Salir");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Producto producto = new Producto();
            CrudProductos CrudProductos = new CrudProductos();
            Console.WriteLine("Ingrese el nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock");
            producto.Stock = int.Parse(Console.ReadLine());
            CrudProductos.guardar(producto);
            break;
        case 2:
            break;
    }
    Console.WriteLine("¿Desea volver a ejecutar el programa?");
    Console.WriteLine("1 - SI");
    Console.WriteLine("2 - NO");
    int seguir = int.Parse(Console.ReadLine());
    if(seguir != 1)
    {
        break;
    }

}
