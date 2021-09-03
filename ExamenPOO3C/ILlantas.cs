using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public interface ILlantas
    {
        string tamaño();
    }

    public class LlantasPequeñas : ILlantas
    {
        public string tamaño()
        {
            return "Llantas de 6 pulgadas";
        }

    }

    public class LlantasGrandes: ILlantas
    {
        public string tamaño()
        {
            return "Llantas de 12 pulgadas";
        }
    }

    //Definimos la interfaz de las llantas, y sus clases concretas para unas llantas pequeñas para un vehiculo pequeño
    //y unas llantas más grandes que serán para un camión
}
