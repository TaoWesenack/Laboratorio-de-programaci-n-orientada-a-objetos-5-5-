/******************************************************************************

Escribe un programa que pida al usuario que adivine un número secreto generado aleatoriamente. 
El programa debe dar pistas al usuario diciéndole si el número ingresado es mayor o menor que el número secreto.

*******************************************************************************/
using System;
class Programa {
    
	static void Main() {
        
        Console.WriteLine("Ingrese un numero para adivinar el secreto");
        
        int numero_usuario = 0;
        
        Random num = new Random();
        int numero = num.Next(1, 21);
        
        
        while (numero_usuario != numero){
            
            numero_usuario = int.Parse(Console.ReadLine());
            
            if (numero_usuario < numero){
                Console.WriteLine("El numero secreto es mayor");
            }
            else if (numero > numero)
            {
                Console.WriteLine("El numero secreto es menor");
            }
            else{
                Console.WriteLine("Adivinaste, el numero secreto era: " + numero);
            }
    }
}
}