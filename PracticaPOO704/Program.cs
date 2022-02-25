using System;

namespace PracticaPOO704
{
    internal class Program
    {
        static void Main(string[] args)

        {
          
            Persona sara = new ();
            Console.WriteLine("\n Ingresa tu nombre");
            sara.SetNombre(Console.ReadLine());

            Console.WriteLine("\n Ingresa tu edad");
            sara.SetEdad(int.Parse(Console.ReadLine()));

            Console.WriteLine("\n Ingresa tu número de documento");
            sara.SetDocumento(Console.ReadLine());

            Console.WriteLine($"Su nombre es: {sara.ObtenerNombre()}, su edad es: {sara.ObtenerEdad()} y el número de identificación es: {sara.ObtenerDocumento()}. ");

            Console.WriteLine("Ingrese el nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            var edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de documento:");
            var documento = Console.ReadLine();

            // se utiliza el contructor
            var dony = new Persona(nombre, edad, documento);
            Console.WriteLine("Su nombre es: " + dony.ObtenerNombre() + "Su edad es: " + dony.ObtenerEdad() + "Su documento es: " + dony.ObtenerDocumento());












        }

    }
}
