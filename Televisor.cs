using System;
using EjTelevisor;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace EjTelevisor
{
    internal class Televisor
    {
        private string brand, model;
        private byte inches, channelTV;
        private bool stateTV;
        private const byte QChannels = 150;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public byte Inches { get => inches; set => inches = value; }
        public bool StateTV
        {
            get { return stateTV; }
            private set { stateTV = value; }
        }
        public byte ChannelTV 
        {
            get { return channelTV; }
            private set { channelTV = value; }
        }


        public Televisor(string marca, string modelo, byte pulgadas)
        {
            Brand = marca;
            Model = modelo;
            Inches = pulgadas;
            ChannelTV = 1;
            StateTV = false;
        }

        // Formato de salida de los datoS:
        public override string ToString()
        {
            return $":{Brand} {Model}, {Inches} pulgadas";
        }
 
    //=== METODOS ===

    //Se muestra el canal que está sintonizando el televisor 
        public byte ObtenerCanalActual()
        {
            Console.WriteLine($"Canal actual: {ChannelTV}");
            return ChannelTV;
        }

   //Se constata en qué estado está el televisor
        public bool VerPrendido()
        {
            string currStatus = "apagado";
            if (stateTV)
            {
                currStatus = "encendido";
            }
            Console.WriteLine($"El televisor está {currStatus}");
            return stateTV;
        }

   // Se cambia el estado(si está apagado, se enciende, si está encendido, se apaga)
        public void CambiarEstado()
        {
            string newEstado;
            if (stateTV)
            {
                stateTV = false;
                newEstado = "apagado";
            }
            else
            {
                stateTV = true;
                newEstado = "encendido";
            }
            Console.WriteLine($"Se cambió el estado de la TV a {newEstado} ");
        }

    //  Se cambia de canal, pasando el nuevo número de canal como parámetro.
        public bool CambiarCanal(byte newChannel)
        {
            if (stateTV && newChannel != ChannelTV && newChannel > 0 && newChannel <= QChannels)
            {
                ChannelTV = newChannel;
                Console.WriteLine($"Se cambió a canal {ChannelTV} ");
                return true;
            }
            else if (!stateTV)
            {
                Console.WriteLine("El televisor está apagado");
                return false;
            }
            else if (newChannel == ChannelTV)
            {
                Console.WriteLine("El televisor ya está sintonizado en ese canal");
                return false;
            }
            else if (newChannel > QChannels || newChannel <= 0)
            {
                Console.WriteLine($"Se marcó el canal {newChannel} que está fuera de rango. El canal debe estar entre 1 y 150");
                return false;
            }
            return false;
        }

    //Se pasa al canal siguiente del actual, siempre que el nuevo canal pertenezca al rango permitido. De lo contrario, se sintoniza en canal 1
            public bool CambiarCanal()
        {
            if (!stateTV)
            //Muchos televisores se encienden al presionar la tecla de avanzar un canal. Es lo que representé acá.
            //Si la TV está apagada, al pedirle que avance un canal, se enciende en el canal presintonizado

            {
              Console.WriteLine("El televisor está apagado. Vamos a encenderlo");
              CambiarEstado();
              Console.WriteLine("Televisor encendido");
             }
           if (ChannelTV < QChannels)  //Ahora se cambia el canal
           {
               ChannelTV += 1;
           }
            else
            {
                ChannelTV = 1;
            }
            Console.WriteLine($"Se cambió a canal {ChannelTV} ");
            return true;                   
        }
    }
}

