using System;
using NUnit.Framework;
using DemoEmpleadosParaTesting;

namespace NombreProyecto.UnitTests
{
    [TestFixture]
    public class EmpleadoTests
    {
        [Test]
        public void SubirSueldo_WhenCalled_ReturnNewSalaryOfArguments()
        {
            //Arrange - Preparacion
            var empleadoUno = new Empleado();
            empleadoUno.Sueldo = 100;

            //Act - Ejecución

            empleadoUno.SubirSueldo(50);

            //Assert - Combiracion

            Assert.That(empleadoUno.Sueldo, Is.EqualTo(150));
        }

        [Test]
        public void BonificacionSueldo_WhenCalled_ReturnNewSalaryOfArguments()
        {
            //Si la calificación del empleado es menor a 5, se le descontará un 10% recibido por parametro.
            //Si la calificación del empleado es igual o mayor a 5, se le aumentara un 20% recibido por parametro.

            //Arrange - Preparacion
            var empleadoUno = new Empleado();
            empleadoUno.Sueldo = 100;
            empleadoUno.Calificacion = 5;
            //Act - Ejecución

            empleadoUno.BonificacionSueldo();

            //Assert - Combiracion
            
            Assert.That(empleadoUno.Sueldo, Is.EqualTo(120));

            //La prueba deberia pasar, ya que tiene calificacion 6 y el EqualTo es 120.
            //Si se cambia el EqualTo a cualquier otro valor sin modificar la calificacion no deberia pasar
            //la prueba deberia pasar si la calificacion se cambia por un valor inferior a 5 y el EqualTo recibe 90 
            
        }
    }
}
