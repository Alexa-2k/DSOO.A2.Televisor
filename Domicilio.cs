using System;
using EjTelevisor;
using System.Text;

namespace EjTelevisor
{
    internal class Domicilio
    {
        private string calle, barrio;
        private ushort numero;

        // Encapsulado. Get set. 
        public string Calle 
        { 
            get { return calle; } 
            set { calle = value; } 
        }
        public ushort Numero 
        { 
            get { return numero; } 
            set { numero = value; } 
        }
        public string Barrio 
        { 
            get { return barrio; } 
            set { barrio = value; } 
        }
        
        //Formato de salida de los datos:
        public override string ToString()
        {
            return $"Domicilio: {Calle}  {Numero}, {Barrio}";
        }
        public Domicilio(string calle, ushort numero, string barrio)
        {
            Calle = calle;
            Numero = numero;
            Barrio = barrio;
        }
        
        

    }

}
