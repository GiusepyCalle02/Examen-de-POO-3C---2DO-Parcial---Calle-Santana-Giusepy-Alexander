using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public interface IBuilder
    {
        //Esta interfaz nos permite colocar las acciones que va a llevar a cabo el constructor

        public void ConstruirMotor();
        public void ConstruirCarroceria();
        public void ConstruirLlantas();
    }
}
