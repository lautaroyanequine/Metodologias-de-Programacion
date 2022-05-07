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

	 public interface Coleccionable : iterable,Ordenable{
	 		
	 		// Los coleccionables van a tener que saber y declarar como iterar sus elementos
		int cuantos();
		bool contiene( Comparable c);
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		void ordenar();

	}
	 	
	public interface CompararAlumnos{
	 		//Paso 1 interface Estrategia - Strategy
	 		/*Va a teber todos aquellos metodos complicados de mantener.
			Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparar alumnos .*/
	 		bool compararIgual(IAlumno a,IAlumno b);
	 		bool compararMayor(IAlumno a,IAlumno b);
	 		bool compararMenor(IAlumno a,IAlumno b);
	 		
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
	 	
	 	
	//Paso 0 de Factory 	
	public interface IFabricaDeComparable{
	 		
	 		Comparable crearAleatorio();
	 		
	 		Comparable crearPorTeclado();
	}
	
	public interface IFabricaDeColeccionables{
		Coleccionable crearColeccionable();
	}
	
	//Observer 
	//Paso 1 interfaces
	
	//Tambienn se puede implementar con clase abstracta
	public interface IObservador{
		void actualizar(IObservado o); //Me entero del cambio
	}
	
	public interface IObservado{
		void agregarObservador(IObservador o);
		void eliminarObservador(IObservador o);
		void notificar(); //Cambie paso algo
	}
	
	
	//Decorator
	public interface IAlumno:Comparable{
		
		// Paso 1. Crear la interface componente
		//Poner todos los metodos de ali,m
		//meter todos los metodos q neceistamos para la implementacion
		//Equivale a la componente -superclase
		int getLegajo();
		void setLegajo(int l);
		
		int getDni();
		void setDni(int d);
		int getPromedio();
		void setPromedio(int p);
		string getNombre();
		void setNombre(string n);
		void setCalificacion(int c);
		int getCalificacion();
		void cambiarEstrategia(CompararAlumnos a);
		bool sosIgual(Comparable x);
		bool sosMenor(Comparable x);
		bool sosMayor(Comparable x);
		
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
		string ToString();
	}
	
	
	//Command
	//Paso 1 . Crear la superclase(Interface)
	
	public interface OrdenEnAula1{
		//La interface IOrden la podemos implementar como una interface con un único método ejecutar
		void ejecutar();
	}
	 	
		
	public interface OrdenEnAula2{
		//La interface IOrden la podemos implementar como una interface con un único método ejecutar
		void ejecutar(Comparable comparable);
	}
	
	

	
	public interface Ordenable{
		void setOrdenInicio(OrdenEnAula1 or);
		void setOrdenLlegaAlumno(OrdenEnAula2 or);
		void setOrdenAulaLlena(OrdenEnAula1 or);
		
		
		
	}
	
	
		 	
}
