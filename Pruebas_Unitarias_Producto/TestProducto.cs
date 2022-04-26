using Dispensador;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Unitarias_Producto
{
    [TestClass]
    public class TestProducto
    {
      

        [TestMethod]
        public void SumarCantidad()
        {
            //Arrange

            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;
            int esperado = producto.Cantidad + producto.Cantidad;


            //Act
            producto.SumarCantidad(producto.Cantidad);

            //Assert

            Assert.AreEqual(esperado, producto.Cantidad);


        }
        [TestMethod]
        public void CuandoSeValidaLaCantidad()
        {
            //Arrange

            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;



            //Act
            bool cantidad = producto.ValidarCantidad();

            //Assert

            Assert.IsTrue(cantidad);


        }
        [TestMethod]
        public void SeValidaElValorSiIngresaDineroMayorAValor()
        {
            //Arrange

            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;



            //Act
            bool cambio = producto.ValidarValor(10000);

            //Assert

            Assert.IsTrue(cambio);


        }
        [TestMethod]
        public void SeValidaElValorSiIngresaDineroMenorAValor()
        {
            //Arrange

            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;



            //Act
            bool cambio = producto.ValidarValor(1000);

            //Assert

            Assert.IsFalse(cambio);


        }

        [TestMethod]
        public void RestarProducto()
        {
            //Arrange

            Producto producto = new Producto();
            producto.Codigo = "01";
            producto.Nombre = "Coca Cola";
            producto.Valor = 3000;
            producto.Categoria = "B";
            producto.Cantidad = 3;
            int esperado = producto.Cantidad-1;


            //Act
            producto.RestarProducto();

            //Assert

            Assert.AreEqual(esperado, producto.Cantidad);


        }

    }
}