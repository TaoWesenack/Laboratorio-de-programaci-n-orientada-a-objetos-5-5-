/******************************************************************************

Escribe un programa que pida al usuario que ingrese un número del 1 al 7 y 
determine a qué día de la semana corresponde (1 es lunes, 2 es martes, etc.). 
Si el número no está en ese rango, el programa debe mostrar un mensaje de error.

*******************************************************************************/
using System;

class programa {

    static void dias(int numero){
        
        switch(numero){
            
            case 1:
                Console.WriteLine("Es lunes");
                break;
            case 2:
                Console.WriteLine("Es martes");
                break;
            case 3:
                Console.WriteLine("Es miercoles");
                break;
            case 4:
                Console.WriteLine("Es jueves");
                break;
            case 5:
                Console.WriteLine("Es viernes");
                break;
            case 6:
                Console.WriteLine("Es sabado");
                break;
            case 7:
                Console.WriteLine("Es domingo");
                break;
            default:
                Console.WriteLine("El numero ingresado no esta dentro del rango (1-7)");
                break;
        }
    }

	static void Main() {
		Console.WriteLine("Ingrese una numero (1 al 7): ");
			int numero = int.Parse(Console.ReadLine());
		
		dias(numero);
	}
	}