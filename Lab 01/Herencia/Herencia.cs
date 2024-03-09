using Lab_01.Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Herencia
{
    public class Carro
    {
        public string marca { get; set; }
        public string placa { get; set;}
        public int  anio { get; set; }

        public string modelo { get; set; }

    }

    public class Toyota : Carro
    {
        public void setAgregarCarro()
        {
            Console.WriteLine("Agregando carro Toyota");
            this.marca = "Toyota";
            this.placa = "ABC123";
            this.anio = 2024;
            this.modelo = "Corolla";
        }

        public void getMostrarCarros()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.placa);
            Console.WriteLine(this.anio);
            Console.WriteLine(this.modelo);
        }
    }

    public class Hyundai : Carro
    {
        public void setAgregarCarro()
        {
            Console.WriteLine("Agregando carro Hyundai");
            this.marca = "Hyundai";
            this.placa = "ABC456";
            this.anio = 2024;
            this.modelo = "Accent";
        }

        public void getMostrarCarros()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.placa);
            Console.WriteLine(this.anio);
            Console.WriteLine(this.modelo);
        }
    }

}
