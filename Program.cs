using EjTelevisor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace EjTelevisor
{
       public class Test
       {
            static void Main(string[] args)
            {
            Domicilio domicilio = new Domicilio("Jonte", 5299, "Monte Castro");
            Televisor teleCompartida = new Televisor("Toshiba", "Semp", 50);
            Persona Facundo = new Persona("Facundo", domicilio, teleCompartida);
            Persona Camila = new Persona("Camila", domicilio, teleCompartida);

            //Se muestran los datos de Facundo y Camila, incluyendo domicilio y datos del televisor
            Console.WriteLine(Facundo);
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("\n" + Camila);
            Console.WriteLine("\n----------------------------------------------");

            Console.WriteLine("\n" + "Se testean los métodos");                

            //1. Se constata en qué estado está el televisor
            teleCompartida.VerPrendido();

            //2. Se cambia el estado (si está apagado, se enciende, si está encendido, se apaga)
            teleCompartida.CambiarEstado();

            //3. Se muestra el canal que está sintonizando el televisor 
            teleCompartida.ObtenerCanalActual();

            //4. Se cambia de canal.
            //   Se pide cambiar a un canal fuera del rango permitido
            teleCompartida.CambiarCanal(200);

            //   Se pide cambiar a un canal perteneciente al rango permitido
            teleCompartida.CambiarCanal(150);

            //5. Se pasa al canal siguiente, siempre que pertenezca al rango permitido. De lo contrario, se sintoniza en canal 1 
            //Se tuvo en cuenta que muchos TV se encienden al presionar la tecla de avance de canal
            teleCompartida.CambiarCanal();

            //6. Se vuelve el televisor al estado original
            teleCompartida.CambiarEstado();

            Console.WriteLine("\n-----------------------------------------");

            //Se prueban los métodos con las personas 

            Console.WriteLine("\nFacundo verifica si el televisor está encendido");
            Facundo.Tele.VerPrendido();
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nSi está apagado, lo enciende. Si está encendido, lo apaga");
            Facundo.Tele.CambiarEstado();
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nCamila mira en qué canal está sintonizado el televisor");
            Camila.Tele.ObtenerCanalActual();
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nCamila se confunde al cambiar de canal");
            Camila.Tele.CambiarCanal(250);
            Console.WriteLine("\ny lo corrige");
            Camila.Tele.CambiarCanal(150);
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nFacundo pasa al canal siguiente");
            Facundo.Tele.CambiarCanal();
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nFacundo cambia de canal");
            Facundo.Tele.CambiarCanal(135);
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nCamila pasa al canal siguiente");
            Camila.Tele.CambiarCanal();
            Console.WriteLine("\n===============================================");
            
            Console.WriteLine("\nCamila apaga el televisor");
            Camila.Tele.CambiarEstado();
            Console.WriteLine("\n-----------------------------------------------");
            }    
        } 
}







