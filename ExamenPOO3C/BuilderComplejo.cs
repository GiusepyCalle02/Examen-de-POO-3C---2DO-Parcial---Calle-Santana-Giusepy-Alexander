using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO3C
{
    public class BuilderComplejo: IBuilder
    {
        //En esta clase, tenemos los metodos constructores, al ser Builder Complejo está dirigido
        // a construir cada parte del vehiculo que son del tipo grande específicamente para un camión.

        public Producto auto = new Producto();

        public void ConstruirCarroceria()
        {
            auto.AñadirCarroceria(new CarroceriaGrande());
        }

        public void ConstruirMotor()
        {
            auto.AñadirMotor(new MotorGrande());
        }

        public void ConstruirLlantas()
        {
            auto.AñadirLlantas(new LlantasGrandes());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }

        //Hemos observado que luego de instanciar un objeto - Producto llamado auto, en cada metodo construir 
        //creamos una carroceria, motor y llantas de tipo grande para el vehiculo camión y cada una de estas las añadimos a dicho vehiculo.
    }
}
