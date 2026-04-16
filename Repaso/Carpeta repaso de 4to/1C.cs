/******************************************************************************

Escribe un programa que pida al usuario que ingrese su edad y determine si es mayor de edad (18 años o más) o menor de edad.

*******************************************************************************/
using System;

class programa {
    
    static bool Verificar(int numero){
        
        if (numero >= 18){
            
            return true;
        }
        else{
            return false;
        }
    
}
  static void Main() {
    Console.WriteLine("Ingrese su edad: ");
    int numero = int.Parse(Console.ReadLine());

    
    if(Verificar(numero)){
  
        Console.WriteLine("Sos mayor de edad");
    }
    else{
        Console.WriteLine("Sos menor de edad");
    }
}
}