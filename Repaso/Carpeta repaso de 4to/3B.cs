/******************************************************************************

Escribe un programa que pida al usuario que ingrese una cadena de texto y 
luego cuente cuántas veces aparece una letra específica en la cadena.

*******************************************************************************/
using System;
class Programa {
	static void Main() {

		Console.WriteLine("Escriba un texto:");
		string palabra = Console.ReadLine();
		
		Console.WriteLine("Escriba una letra especifica para buscar en el texto:");
        char letra = Console.ReadLine()[0];
        
        int contador = 0;
        
		for(int i = 0; i < palabra.Length; i++){
		    
		    if(palabra[i] == letra){
		        
		      contador ++;
		    }
		    
		}
		
		Console.WriteLine("La letra " + letra + " Aparece " + contador + " veces en el texto");
	}
}