using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEmpleadosParaTesting
{
    public class Empleado
    {
        //Propiedades o atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }

        public double Calificacion { get; set; }
        public double Sueldo { get; set; }

        //Métodos

        public void Inicializar()
        {
            Console.Write("Ingrese nombre: ");
            Nombre = Console.ReadLine();


            Console.Write("Ingrese apellido: ");
            Apellido = Console.ReadLine();


            Console.Write("Ingrese departamento: ");
            Departamento = Console.ReadLine();

            string linea;

            Console.Write("Ingrese sueldo: ");
            linea = Console.ReadLine();
            Sueldo = int.Parse(linea);
        }

        public string ObtenerFicha()
        {
            string ficha =
            "Nombre completo:" + this.Nombre + " " + this.Apellido + Environment.NewLine +
            "Departamento: " + this.Departamento + Environment.NewLine +
            "Sueldo:" + this.Sueldo + " Pesos" + Environment.NewLine;

            return ficha;

        }

        public void SubirSueldo(double porcentaje)
        {
            //this.Sueldo += porcentaje * this.Sueldo / 100;
            this.Sueldo = this.Sueldo + porcentaje * this.Sueldo / 100;
        }

       
        public void BonificacionSueldo()
        {
            if (this.Calificacion >= 5)
            {
                this.Sueldo = this.Sueldo + 20 * this.Sueldo / 100;
            }
            else { this.Sueldo = this.Sueldo - 10 * this.Sueldo / 100; }

           
            
        }
       

    }
}
