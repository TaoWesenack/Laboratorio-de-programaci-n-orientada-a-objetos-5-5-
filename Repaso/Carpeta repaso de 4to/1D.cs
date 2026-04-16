/******************************************************************************

Escribe un programa que pida al usuario que ingrese una letra del alfabeto y determine si es una vocal o una consonante.

*******************************************************************************/
using System;

class programa {

	static bool Verificar(char letra) {

		if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
		   
            return true;
		}
		else{
		    return false;
		}
	}
	static void Main() {
		Console.WriteLine("Ingrese una letra: ");
			char letra = (Console.ReadLine()[0]);
			letra = char.ToLower(letra);
			
			if(Verificar(letra)) {

			Console.WriteLine("La letra " + letra + " es vocal");
			}
			else {
				Console.WriteLine("La letra " + letra + " no es una vocal");
			}
		}
	}