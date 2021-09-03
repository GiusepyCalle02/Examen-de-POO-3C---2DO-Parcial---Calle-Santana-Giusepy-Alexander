using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public class Producto
    {
        private ICarroceria carroceria;
        private IMotor motor;
        private ILlantas llantas;

        public void AñadirCarroceria(ICarroceria cCarroceria)
        {
            carroceria = cCarroceria;
            Console.WriteLine("Se ha colocado la carroceria: {0}", carroceria.caracteristicas());
        }

        public void AñadirMotor(IMotor cMotor)
        {
            motor = cMotor;
            Console.WriteLine("Se ha colocado el motor: {0}", motor.detalles());
        }

        public void AñadirLlantas(ILlantas cLlantas)
        {
            llantas = cLlantas;
            Console.WriteLine("Se ha colocado las llantas: {0}", llantas.tamaño());
        }

        public void MostrarVehiculo()
        {
            Console.WriteLine("El vehiculo tiene {0}, {1}, {2}", carroceria.caracteristicas(), motor.detalles(), llantas.tamaño());
        }

        //Esta clase representa el producto que el Builder va a construir a través de lo que le diga el instructor
    }
}
