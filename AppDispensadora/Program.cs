// See https://aka.ms/new-console-template for more information
using Dispensador;

Dispensadora dispensador = new Dispensadora();
Console.WriteLine("Bienvenidos a la dispensadora de Sara");
while (true)
{
    

    Console.WriteLine(dispensador.ListarProducto());






    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Modificar producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Comprar producto");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Producto producto = new Producto();
            Console.WriteLine("Codigo");
            producto.Codigo = Console.ReadLine();

            Console.WriteLine("Nombre");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Categoria");
            producto.Categoria = Console.ReadLine();

            Console.WriteLine("Cantidad");
            producto.Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor");
            producto.Valor = double.Parse(Console.ReadLine());

            dispensador.AgregarProducto(producto);

            break;
        case "2":
        // codigo para modificar
        case "3":
            Console.Write("Codigo");
            string codigo = Console.ReadLine();

            dispensador.EleminarProducto(codigo);
            break;
        case "4":
            Console.Write("Codigo");
            string codigo_venta = Console.ReadLine();

            Console.WriteLine("Monedas solo de 1000-500-200-100");
            dispensador.Pago = Console.ReadLine();

            Producto pcomprado = dispensador.Vender(codigo_venta);

            if (pcomprado == null)
            {
                Console.WriteLine("No se puede comprar el producto");

            }
            else
            {
                Console.WriteLine("Su producto es {0} y la devuelta es {1}", pcomprado.Codigo, pcomprado.Cambio);
            }
            break;
















    }
    Console.WriteLine("Desea continuar si/no");

    if (Console.ReadLine() == "no")
    {
        break;
    }

}


