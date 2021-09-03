using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public interface IMotor
    {
        string detalles();
    }

    public class MotorPequeño : IMotor
    {
        public string detalles()
        {
            return "Motor con potencia de 120/5000 kW/rpm";
        }
    }

    public class MotorGrande : IMotor
    {
        public string detalles()
        {
            return "Motor con potencia de 228/5700 kW/rpm";
        }
    }

    //Definimos la interfaz del motor, y sus clases concretas para un motor para un vehiculo pequeño
    //el cual tendrá un motor con una potencia y un motor para un vehiculo grande que será para un camión con un motor con
    //mayor potencia
}
