using System;

class Programa {
  static void Main() {
      
      Random random = new Random();
      int numero = random.Next(1, 101);
      int intento = 0;
      
      Console.WriteLine("Adivina el numero entre 1 y 100");
      
      while (intento != numero) {
          intento = int.Parse(Console.ReadLine());
          
          if (intento > numero) {
              Console.WriteLine("El numero es menor");
          } else if (intento < numero) {
              Console.WriteLine("El numero es mayor");
          } else {
              Console.WriteLine("Ganaste");
          }
      }
  }
}