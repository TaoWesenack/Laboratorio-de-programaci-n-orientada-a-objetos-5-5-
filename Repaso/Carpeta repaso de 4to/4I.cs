using System;
using System.Collections.Generic;
using System.Threading;

class Programa {
  static void Main() {
      
      List<int> numeros = new List<int>();
      Random random = new Random();
      
      for (int i = 0; i < 5; i++) {
          numeros.Add(random.Next(1, 10));
      }
      
      Console.WriteLine("Memoriza los numeros:");
      
      foreach (int n in numeros) {
          Console.Write(n + " ");
      }
      
      Thread.Sleep(3000);
      Console.Clear();
      
      Console.WriteLine("Ingresa los numeros en orden:");
      
      bool correcto = true;
      
      for (int i = 0; i < numeros.Count; i++) {
          int ingreso = int.Parse(Console.ReadLine());
          
          if (ingreso != numeros[i]) {
              correcto = false;
          }
      }
      
      if (correcto) {
          Console.WriteLine("Ganaste");
      } else {
          Console.WriteLine("Perdiste");
      }
  }
}