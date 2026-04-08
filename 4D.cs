using System;
using System.Collections.Generic;

class Programa {
  static void Main() {
      
      List<int> numero = new List <int>(){3,4,5,7,67,5,43,2};
      int suma = 0;
    
      foreach (int i in numero) {
          suma += i;
      }
      
      double promedio = (double)suma / numero.Count;
      
      Console.WriteLine("El promedio es: " + promedio);
  }
}