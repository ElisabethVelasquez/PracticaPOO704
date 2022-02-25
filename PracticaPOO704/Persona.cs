using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO704
{
    internal class Persona
    {
        private  string Nombre;
        private int Edad;
        private string Documento;

        public Persona()
        {

        }
        public Persona(string nombre, int edad, string documento)
        {
            Nombre = nombre;
            Edad = edad;
            Documento = documento;
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;

        }    

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
        
        public void SetDocumento(string documento)
        {
            Documento = documento;
        }
        
        public string ObtenerNombre()
        {
            return Nombre;
        }

        public int ObtenerEdad ()
        {
            return Edad;
        }

        public string ObtenerDocumento ()
        {
            return Documento;
        }

        public int Cumpleanios()
        {
            return Edad + 1;
        }
    }
}
