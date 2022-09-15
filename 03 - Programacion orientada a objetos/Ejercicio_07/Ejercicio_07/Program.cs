using Ejercicio_07.Class;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime fechaPerro = new DateTime(1990, 08, 10);
        DateTime fechaGato1 = new DateTime(1998, 03, 20);
        DateTime fechaGato2 = new DateTime(2006, 10, 05);

        Mascota perro = new Mascota("Perro", "Buddy", fechaPerro);
        Mascota gato = new Mascota("Gato", "Gardfield", fechaGato1);
        gato.Vacuna("Triple Felina");
        Mascota gato2 = new Mascota("Gato", "Pijurro", fechaGato2);
        Mascota perro2 = new Mascota("Perro", "Bobby", fechaGato1);
        perro2.Vacuna("Anti-Rabica");

        Cliente cliente1 = new Cliente("Av. Alvarez Thomas 1552", "Julio", "Roca", 1554174801);
        Cliente cliente2 = new Cliente("Lavalle 395", "Micaela", "Gutierrez", 1562393600);
        Cliente cliente3 = new Cliente("Gorriti 3663", "Cecilia", "Navarro", 1545472129);

        cliente1 += perro;
        cliente2 += gato;
        cliente3 += gato2;
        cliente3 += perro2;

        Console.WriteLine($"{cliente1.Mostrar()}");
        Console.WriteLine($"{cliente2.Mostrar()}");
        Console.WriteLine($"{cliente3.Mostrar()}");
    }
}