# DSOO.A2.Televisor
Diseño de software orientado a objetos -  Práctica formativa A2 - Ejercicio del televisor

Facundo y Camila son compañeros de piso y comparten un televisor. Crear un programa simple en C# para administrar su televisor y controlar los canales que ven.

Atributos del televisor : Marca (del tipo string) Modelo (del tipo string) Cantidad de pulgadas (del tipo entero) Estado (prendido o apagado) (del tipo booleano) Número del canal que se está reproduciendo actualmente. (valor desde 1 a 150) (del tipo entero)

De la persona dueña del televisor se sabe: 
nombre (del tipo string) 
domicilio
Del domicilio se conoce : 
calle, numero, barrio

Hacer:
obtenerCanalActual(): int Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.

cambiarCanal(int): bool Cambia el canal al número de canal que reciba por parámetro

cambiarCanal(): bool Cambia el canal incrementando en uno al que se está reproduciendo actualmente. Si llega al tope de 150, debe comenzar por el primero.

verPrendido():bool Informa con un verdadero si el televisor está encendido o falso en caso contrario.

cambiarEstado():void Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.

Se pide: 
Modelar la solución en UML 
Realizar la implementación de cada método en c#. 
También realizar los constructores de las siguientes clases: Persona Televisor. Domicilio.

El método Main de la clase Test debe instanciar lo siguiente y luego mostrarlo: 
Un televisor que le pertenece a Facundo y a Camila 
Ambos viven juntos en Jonte 5299, Monte Castro 
Tanto Facundo como Camila, en distintos momentos, pueden realizar diferentes operaciones sobre mismo televisor (tener siempre en cuenta el estado del televisor: por ejemplo, no se puede cambiar de canal si se encuentra apagado).
