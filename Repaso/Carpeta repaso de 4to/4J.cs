using System;

class Programa {
  static void Main() {
      
      string[] palabras = {"rojo", "azul", "verde"};
      Random random = new Random();
      
      string palabra = palabras[random.Next(0, palabras.Length)];
      char[] progreso = new char[palabra.Length];
      
      for (int i = 0; i < progreso.Length; i++) {
          progreso[i] = '_';
      }
      
      int aciertos = 0;
      
      while (aciertos < palabra.Length) {
          Console.WriteLine(new string(progreso));
          Console.WriteLine("Ingresa una letra:");
          
          char letra = char.Parse(Console.ReadLine());
          bool encontro = false;
          
          for (int i = 0; i < palabra.Length; i++) {
              if (palabra[i] == letra && progreso[i] == '_') {
                  progreso[i] = letra;
                  aciertos++;
                  encontro = true;
              }
          }
          
          if (!encontro) {
              Console.WriteLine("Error");
          }
      }
      
      Console.WriteLine("Ganaste");
  }
}