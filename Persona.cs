using System;
using EjTelevisor;
using System.Text;
namespace EjTelevisor
{
    internal class Persona
    {
        private string name;
        private Domicilio address;
        private Televisor tele;

        //Encapsulamiento. Get/Set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Televisor Tele 
        {
            get { return tele; }
            set { tele = value; }
        }
        public Domicilio Address 
        {
            get { return address; }
            set { address = value; }
        }

        //Formato de salida de los datos
        public override string ToString()
        {
            return $"Nombre: {Name} ||  {address} || Televisor {tele}";
        }

        public Persona(string nombre, Domicilio address, Televisor tele)
        {
            Name = nombre;
            Address = address;
            Tele = tele;
        }

    }
}




