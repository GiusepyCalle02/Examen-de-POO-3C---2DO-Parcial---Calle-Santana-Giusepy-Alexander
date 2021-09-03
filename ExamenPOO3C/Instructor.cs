using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public class Instructor
    {
        public void Construir(IBuilder cConstructor)
        {
            //Esta clase instructor indica los pasos para hacer la construcción
            //en este caso estamos indicando que primero construya la carroceria,
            //luego el motor y por último las llantas

            cConstructor.ConstruirCarroceria();
            cConstructor.ConstruirMotor();
            cConstructor.ConstruirLlantas();
        }
    }
}
