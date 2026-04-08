using System;
using System.Collections.Generic;

class Programa {
  static void Main() {
      
      List<int> numero = new List <int>(){3,4,5,7,67,5,43,2};
      int min = numero[0];
    
      foreach (int i in numero) {
          if(i < min){
              min = i;
          }
      }
      
      Console.WriteLine("El numero minimo es: " + min);
  }
}