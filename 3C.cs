/******************************************************************************

Escribe un programa que pida al usuario que ingrese números enteros positivos y 
luego calcule la suma de todos los números ingresados hasta que el usuario ingrese un número negativo.

*******************************************************************************/
using System;
class HelloWorld {

    
  static void Main() {
      
      int numero = 0;
      int contador = 0;
      Console.WriteLine("Escribe un numero entero:");
     
      while (numero >= 0){
        numero = int.Parse(Console.ReadLine());
        if (numero > 0){
        contador += numero;
        }
    }
  Console.WriteLine("La suma de los numero ingresados es: " + contador);
}
}