/******************************************************************************

Escribe un programa que lea un número entero y determine si es positivo, negativo o cero.

*******************************************************************************/
using System;
class Programa {
  static void Main() {
    Console.WriteLine("Escriba un numero entero: ");
    int numero = int.Parse(Console.ReadLine());
    
    determinar(numero);
  }
  static void determinar(int numero) {
      
     if (numero < 0){
     
        Console.WriteLine("El numero es negativo");
     }
     else if (numero == 0){
         
         Console.WriteLine("El numero es igual a 0");
     }
     else{
         
         Console.WriteLine("El numero es positivo");
     }
     
  }
}