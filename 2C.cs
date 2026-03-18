/******************************************************************************

Escribe un programa que muestre las tablas de multiplicar del 1 al 10.

*******************************************************************************/
using System;
class Programa {
    static void Main() {

        for(int i = 1; i <= 10; i++) {

            Console.WriteLine("Tabla del " + i);

            for(int b = 1; b <= 10; b++) {
                Console.WriteLine(i + " x " + b + " = " + (i * b));
            }

            Console.WriteLine();
        }
    }
}