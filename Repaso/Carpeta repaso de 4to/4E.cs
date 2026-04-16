using System;
using System.Collections.Generic;

class Programa {
  static void Main() {
      
      List<int> numero = new List <int>(){3,4,5,7,67,5,43,2};
      int pares = 0;
    
      foreach (int i in numero) {
          if(i % 2 == 0){
              pares++;
          }
      }
      
      Console.WriteLine("Hay " + pares + " pares en el arreglo");
  }
}