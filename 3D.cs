/******************************************************************************

Escribe un programa que simule una carrera entre dos corredores. 
Cada corredor avanza un número de metros generado aleatoriamente en cada iteración del ciclo. 
El programa debe mostrar quién ganó la carrera y en cuántos segundos.

*******************************************************************************/
using System;

class programa {

  static void Main() {

    Random random = new Random();

    int corredor1 = 0;
    int corredor2 = 0;
    int final = 100;
    int segundos = 0;

    while (corredor1 < final && corredor2 < final) {

      int avance1 = random.Next(1, 40); 
      int avance2 = random.Next(1, 40);

      corredor1 += avance1;
      corredor2 += avance2;

      segundos++;

      Console.WriteLine("Segundo " + segundos);
      Console.WriteLine("Corredor 1: " + corredor1 + " metros");
      Console.WriteLine("Corredor 2: " + corredor2 + " metros");
      Console.WriteLine("------------------------");
    }

    if (corredor1 >= final && corredor2 >= final) {
      Console.WriteLine("¡Empate en " + segundos + " segundos!");
    }
    else if (corredor1 >= final) {
      Console.WriteLine("Ganó el corredor 1 en " + segundos + " segundos");
    }
    else {
      Console.WriteLine("Ganó el corredor 2 en " + segundos + " segundos");
    }
  }
}