using System;

class Programa {
  static void Main() {
      
      Random random = new Random();
      string[] opciones = {"piedra", "papel", "tijera"};
      
      Console.WriteLine("Elige: piedra, papel o tijera");
      string usuario = Console.ReadLine();
      
      string computadora = opciones[random.Next(0,3)];
      
      Console.WriteLine("La computadora eligio: " + computadora);
      
      if (usuario == computadora) {
          Console.WriteLine("Empate");
      } else if (
          (usuario == "piedra" && computadora == "tijera") ||
          (usuario == "papel" && computadora == "piedra") ||
          (usuario == "tijera" && computadora == "papel")
      ) {
          Console.WriteLine("Ganaste");
      } else {
          Console.WriteLine("Perdiste");
      }
  }
}