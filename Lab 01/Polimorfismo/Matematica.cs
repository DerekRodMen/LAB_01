using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Polimorfismo
{
    public class Matematica
    {
            public virtual void Ecuacion()
            {
                Console.WriteLine("Ejectuando la ecuacion\n");
            }

    }
    public class Suma : Matematica
    {
        public override void Ecuacion()
        {
            Console.WriteLine("Ejecutando la suma: ");
        }

    }


    public class Resta : Matematica
    {
        public override void Ecuacion()
        {
            Console.WriteLine("Ejecutando la resta: ");
        }

    }

   public class Multiplicar : Matematica
    {
        public override void Ecuacion()
        {
            Console.WriteLine("Ejecutando la multiplicacion: ");
        }

    }

}
