using Dispensador;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Unitarias_Validaciones
{
    [TestClass]
    public class TestValidaciones
    {
        [TestMethod]
        public void ValidarProductoSiExite()
        {
            //Arrange
            Dispensadora dispensadora = new Dispensadora();
            Validaciones validar = new Validaciones();
            int esperado = 2;

            Producto Cocacola = new Producto();
            Cocacola.Codigo = "01";
            Cocacola.Nombre = "Coca Cola";
            Cocacola.Valor = 300;
            Cocacola.Categoria = "B";
            Cocacola.Cantidad = 3;

            Producto Solterita = new Producto();
            Solterita.Codigo = "02";
            Solterita.Nombre = "Solterita";
            Solterita.Valor = 2000;
            Solterita.Categoria = "C";
            Solterita.Cantidad = 5;


            Producto Papas = new Producto();
            Papas.Codigo = "03";
            Papas.Valor = 2000;
            Papas.Nombre = "Papas Margaritas";
            Papas.Categoria = "C";
            Papas.Cantidad = 10;

            Producto Yogurt = new Producto();
            Yogurt.Codigo = "04";
            Yogurt.Valor = 100;
            Yogurt.Categoria = "C";
            Yogurt.Cantidad = 11;
            Yogurt.Nombre = "Yogurt";
            dispensadora.AgregarProducto(Cocacola);
            dispensadora.AgregarProducto(Solterita);
            dispensadora.AgregarProducto(Papas);
            dispensadora.AgregarProducto(Yogurt);

            




            //Act
            int resultado=validar.ValidaProducto("03");

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void ValidarProductoSiNoExite()
        {
            //Arrange
            Dispensadora dispensadora = new Dispensadora();
            Validaciones validar = new Validaciones();

            int esperado = -1;

            
           
            Producto Cocacola = new Producto();
            Cocacola.Codigo = "01";
            Cocacola.Nombre = "Coca Cola";
            Cocacola.Valor = 300;
            Cocacola.Categoria = "B";
            Cocacola.Cantidad = 3;

            Producto Solterita = new Producto();
            Solterita.Codigo = "02";
            Solterita.Nombre = "Solterita";
            Solterita.Valor = 2000;
            Solterita.Categoria = "C";
            Solterita.Cantidad = 5;


            Producto Papas = new Producto();
            Papas.Codigo = "03";
            Papas.Valor = 2000;
            Papas.Nombre = "Papas Margaritas";
            Papas.Categoria = "C";
            Papas.Cantidad = 10;

            Producto Yogurt = new Producto();
            Yogurt.Codigo = "04";
            Yogurt.Valor = 100;
            Yogurt.Categoria = "C";
            Yogurt.Cantidad = 11;
            Yogurt.Nombre = "Yogurt";
            dispensadora.AgregarProducto(Cocacola);
            dispensadora.AgregarProducto(Solterita);
            dispensadora.AgregarProducto(Papas);
            dispensadora.AgregarProducto(Yogurt);





            //Act
            int resultado = validar.ValidaProducto("10");

            //Assert

            Assert.AreEqual(esperado, resultado);
        }

    }
}