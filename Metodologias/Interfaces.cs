/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 6/4/2022
 * Hora: 10:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	/// 
	
	
	
		//Ejercicio 1
	 public interface Comparable
	{
		bool sosIgual(Comparable x);
		bool sosMenor (Comparable x);
		bool sosMayor (Comparable x);
	}
	 
	 	//Ejercicio 3

	 public interface Coleccionable : iterable{
	 		
	 		// Los coleccionables van a tener que saber y declarar como iterar sus elementos
		int cuantos();
		bool contiene( Comparable c);
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);

	}
	 	
	public interface CompararAlumnos{
	 		//Paso 1 interface Estrategia - Strategy
	 		/*Va a teber todos aquellos metodos complicados de mantener.
			Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparar alumnos .*/
	 		bool compararIgual(Alumno a,Alumno b);
	 		bool compararMayor(Alumno a,Alumno b);
	 		bool compararMenor(Alumno a,Alumno b);
	 		
	}
	 	
	public interface IteradorDePaginas{
	 		
	 		//PASO 1 interface Iterador
	 		
	 		/*  Para recorrer todos los elementos de una colección.Clase que nos va servir para decir como iterar un conjunto de elementos*/
	 		void primero();
	 		void siguiente();
	 		bool fin();
	 		Comparable actual(); //Devuelve un Comparable,en este caso nuestros iterables van a contener Comparables de manera generica.
	 	}
	public interface iterable {
	 		//Paso 3 : crear interface iterable
	 		//Esta interface la deben implementar todos los objetos que posean un iterador para iterar sobre sus elementos
	 		IteradorDePaginas crearIterador();
	 	}

	 
	 	
	
		 	
}
