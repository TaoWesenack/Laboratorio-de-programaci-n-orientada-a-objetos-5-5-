/******************************************************************************

Escribe un programa que calcule la suma de los primeros 100 numeros

*******************************************************************************/
using System;
class Programa {
	static void Main() {



		int resultado = 0;
		for(int i = 1; i < 101; i++) {
			resultado += i;
		}
		Console.WriteLine("La suma del 1 al 100 es: " + resultado);
	}
}