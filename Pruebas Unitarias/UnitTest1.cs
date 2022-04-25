using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pruebas_Unitarias;
using 

namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dispensadora dispensador = new Dispensadora();
            Producto producto = new Producto();

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
        }
    }
}
