using Lab_01.Abstraccion;
using Lab_01.Herencia;
using Lab_01.Polimorfismo;
using System.Security.Cryptography.X509Certificates;


    Matematica[] matematica = new Matematica[3];
    matematica[0] = new Suma();
    matematica[1] = new Resta();
    matematica[2] = new Multiplicar();

    foreach (Matematica matematica1 in matematica)
    {
        matematica1.Ecuacion();
    }

    Console.WriteLine("\n\n\n\n");

    Toyota toyota = new Toyota();
    Hyundai hyundai = new Hyundai();

    toyota.setAgregarCarro();
    hyundai.setAgregarCarro();

    Console.WriteLine("\n\n");

    toyota.getMostrarCarros();
    Console.WriteLine("\n");
    hyundai.getMostrarCarros();

    Console.WriteLine("\n\n\n\n");

    Lab_01.Abstraccion.IVehiculo carro = new Lab_01.Abstraccion.Carro();
    carro.Avanzar();
    carro.Parar();

    Lab_01.Abstraccion.IVehiculo moto = new Lab_01.Abstraccion.Moto();
    moto.Avanzar();
    moto.Parar();






