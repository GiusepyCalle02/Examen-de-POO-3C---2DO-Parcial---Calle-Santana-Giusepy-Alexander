using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public class BuilderSimple: IBuilder
    {
        //En esta clase, tenemos los metodos constructores, al ser Builder simple está dirigido
        // a construir cada parte del auto que son del tipo pequeño.

        public  Producto auto = new Producto();

        public void ConstruirCarroceria()
        {
            auto.AñadirCarroceria(new CarroceriaPequeña());
        }

        public void ConstruirMotor()
        {
            auto.AñadirMotor(new MotorPequeño());
        }

        public void ConstruirLlantas()
        {
            auto.AñadirLlantas(new LlantasPequeñas());
        }

        public Producto ObtenerProducto()
        {
            return auto;
        }

        //Hemos observado que luego de instanciar un objeto - Producto llamado auto, en cada metodo construir 
        //creamos una carroceria, motor y llantas pequeñas y cada una de estas las añadimos al auto.

    }
}
