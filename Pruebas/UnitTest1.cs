using GestionProyectos;

namespace Pruebas
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //configurar 
            var producto = new Producto { Nombre = "Prueba", Precio = -13 };

            //validar
            Assert.True(producto.Precio >= 0, "El Precio no pude ser Negativo");

        }
    }
}