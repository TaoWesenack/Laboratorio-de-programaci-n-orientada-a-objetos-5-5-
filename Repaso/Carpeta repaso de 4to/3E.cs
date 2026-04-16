/******************************************************************************

Escribe un programa que pida al usuario que ingrese números enteros positivos y luego calcule 
el producto de todos los números ingresados hasta que el usuario ingrese un número negativo.

*******************************************************************************/
using System;

class Programa {
    static void Main() {

        int numero;
        int producto = 1; 

        Console.WriteLine("Ingrese números positivos:");

        do {
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0) {
                producto *= numero;
            }

        } while (numero >= 0);

        Console.WriteLine("El producto total es: " + producto);
    }
}