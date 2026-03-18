/******************************************************************************

Escribe un programa que pida al usuario que ingrese una palabra y luego muestre cada letra de la palabra en una lC-nea separada

*******************************************************************************/
using System;
class Programa {
	static void Main() {

		Console.WriteLine("Escriba una palabra:");
		string palabra = Console.ReadLine();

		for(int i = 0; i < palabra.Length; i++) {
			Console.WriteLine(palabra[i]);
		}
	}
}