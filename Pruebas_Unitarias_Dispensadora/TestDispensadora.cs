using Dispensador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Pruebas_Unitarias_Dispensadora
{
    [TestClass]
    public class TestDispensadora
    {
        public TestDispensadora()
        {
            
        }

        [TestMethod]
        public void AgregarSiProductoExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;

            


            //Act
            bool resultado = dispensador.AgregarProducto(producto);

            //Assert

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void AgregarSiProductoNoExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();
            producto.Codigo = "09";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;



            //Act
            bool resultado = dispensador.AgregarProducto(producto);

            //Assert

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void EliminarProductoSiExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;
            dispensador.Productos.Add(producto);



            //Act
            bool resultado = dispensador.EleminarProducto("01");

            //Assert

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void EliminarProductoSiNoExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
          



            //Act
            bool resultado = dispensador.EleminarProducto("10");

            //Assert

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void ModificarProductoSiExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;

            Producto otroproducto = new Producto();
            otroproducto.Codigo = "01";
            otroproducto.Nombre = "Cola Cola";
            otroproducto.Valor = 1000;
            otroproducto.Categoria = "B";
            otroproducto.Cantidad = 3;
            dispensador.AgregarProducto(otroproducto);


            //Act
            bool resultado = dispensador.ModificarProducto(producto);

            //Assert

            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void ModificarProductoSiNoExiste()
        {
            //Arrange
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();
            producto.Codigo = "07";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;
           


            //Act
            bool resultado = dispensador.ModificarProducto(producto);

            //Assert

            Assert.IsFalse(resultado);
        }

    }
}