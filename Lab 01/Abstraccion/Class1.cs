using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Abstraccion
{

    public interface IVehiculo
    {
        void Avanzar();
        void Parar();
    }

    public class Carro : IVehiculo
    {
            public void Avanzar()
            {
                Console.WriteLine("El automóvil Avanza.");
            }

            public void Parar()
            {
                Console.WriteLine("El automóvil para.");
            }
        }

       
        public class Moto : IVehiculo
    {
            public void Avanzar()
            {
                Console.WriteLine("La moto Avanza");
            }

            public void Parar()
            {
                Console.WriteLine("La moto para");
            }
        }

   
}
