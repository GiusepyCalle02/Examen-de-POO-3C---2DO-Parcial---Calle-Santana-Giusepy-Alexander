using System;

namespace ExamenPOO3C
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor miInstructor = new Instructor();

            //Construimos un vehiculo pequeño
            BuilderSimple pequeño = new BuilderSimple();
            miInstructor.Construir(pequeño);

            //Obtenemos el auto
            Producto auto1 = pequeño.ObtenerProducto();

            auto1.MostrarVehiculo();

            Console.WriteLine("-------------------------------------------------------------------------------");

            //Construimos un vehiculo grande (camión)
            BuilderComplejo grande = new BuilderComplejo();
            miInstructor.Construir(grande);

            //Obtenemos el vehiculo camión
            Producto auto2 = grande.ObtenProducto();

            auto2.MostrarVehiculo();


        }
    }
}
