using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public interface ICarroceria
    {
        string caracteristicas();
    }

    public class CarroceriaPequeña : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria para vehículos";
        }
    }

    public class CarroceriaGrande : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria para camiones";
        }
    }

    //Definimos la interfaz de la carroceria, y sus clases concretas para una carroceria para un vehiculo pequeño
    //el cual tendrá una carrocería pequeña y una carroceria grande que será para un camión
}
