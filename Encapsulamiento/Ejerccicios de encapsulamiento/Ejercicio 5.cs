/******************************************************************************

Crea una clase llamada Estudiante que tenga atributos como nombre, edad y notas (una lista de números). 
Implementa métodos para agregar una nota y calcular el promedio de las notas.

*******************************************************************************/
using System;
using System.Collections.Generic;



public class Estudiante {

	public string Nombre {get; set;}

	private int edad;
	public int Edad{

		get {return edad;}

		set {
			if (value>=0) {

				edad = value;
			}
		}

	}

	private List<float> notas;
	public List<float> Notas {
		get { return notas; }
	}


	public Estudiante(string nombre, int edad)

	{
		Nombre=nombre;
		Edad=edad;
		notas = new List<float>();
	}

	public void agregarNota(float nota) {

		if (nota>=1) {

			notas.Add(nota);
		}
	}
	public float promedio() {

		float suma = 0;

		foreach ( float n in notas) {
			suma+=n;
		}
		return suma / notas.Count;
	
	}
}





public class Programa {
	static void Main() {

		Estudiante estudiante1 = new Estudiante("Tao",17);
		estudiante1.agregarNota(6.7f);
		estudiante1.agregarNota(9.f);
		estudiante1.agregarNota(10f);
		Console.WriteLine($"el promedio del estudiante {estudiante1.Nombre} de {estudiante1.Edad} años es de {estudiante1.promedio()}");
	}
}