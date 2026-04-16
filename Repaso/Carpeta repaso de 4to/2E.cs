/******************************************************************************

Escribe un programa que pida al usuario que ingrese un número y luego muestre 
la suma de los números impares desde 1 hasta ese número.

*******************************************************************************/
using System;
class Programa {
    
    static int Verificar(int numero){
        
        int suma = 0;
        
        for(int i = 1; i <= numero; i++){
            
            if (i % 2 != 0){
                
                suma += i;
            }
        }
        
        
        return suma;
        
    }
    
	static void Main() {

		Console.WriteLine("Escriba un numero:");
		int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma de los impares hasta " + numero + " es: " + Verificar(numero));
	}
}