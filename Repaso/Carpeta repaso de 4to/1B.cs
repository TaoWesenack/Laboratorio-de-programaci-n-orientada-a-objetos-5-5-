/******************************************************************************

Escribe un programa que pida al usuario que ingrese dos números y determine cuál es el número más grande.

*******************************************************************************/
using System;

class programa {
    
    static bool Verificar(int numero1, int numero2) {
    
    if (numero1 > numero2){
        
        return true;
    }
    else{
        return false;
    }
    
}
  static void Main() {
    Console.WriteLine("Ingrese 2 numeros: ");
    int numero1 = int.Parse(Console.ReadLine());
    int numero2 = int.Parse(Console.ReadLine());
    
    if(Verificar(numero1, numero2)){
        Console.WriteLine("El numero " + numero1 + " es mayor");
  }
  else{
       Console.WriteLine("El numero " + numero2 + " es mayor");
  }
}
}