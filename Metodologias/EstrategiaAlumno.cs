/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 19/4/2022
 * Hora: 11:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of EstrategiaAlumno.
	/// </summary>
	//Paso 2: implementar subclase.Cada subclase es una estrategia distintas. strategy
	
	public class PorNombre:CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. Este caso de manera alfabaetica.
		public bool compararIgual(Alumno a,Alumno b){
			string nombreA=a.getNombre;
			string nombreB= b.getNombre;
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == 0)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMayor(Alumno a,Alumno b){
			string nombreA=a.getNombre;
			string nombreB= b.getNombre;
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == -1)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMenor(Alumno a,Alumno b){
			string nombreA=a.getNombre;
			string nombreB= b.getNombre;
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == 1)
			{
				return true;
			}
			return false;
			
		}
	}
	
	public class PorDni:CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(Alumno a,Alumno b){
			int dniA=a.getDni;
			int dniB= b.getDni;
			if(dniA == dniB)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMayor(Alumno a,Alumno b){
			int dniA=a.getDni;
			int dniB= b.getDni;
			if(dniA > dniB)
			{
				return true;
			}
			return false;

		

	}

		public bool compararMenor(Alumno a,Alumno b){
			int dniA=a.getDni;
			int dniB= b.getDni;
			if(dniA < dniB)
			{
				return true;
			}
			return false;

		

	}		
	
		

		

	}
	
	public class PorPromedio:CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(Alumno a,Alumno b){
			int promedioA=a.Promedio;
			int promedioB= b.Promedio;
			if(promedioA == promedioB)
			{
				return true;
			}
			return false;
			
		}

		public bool compararMayor(Alumno a,Alumno b){
			int promedioA=a.Promedio;
			int promedioB= b.Promedio;
			if(promedioA > promedioB)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMenor(Alumno a,Alumno b){
			int promedioA=a.Promedio;
			int promedioB= b.Promedio;
			if(promedioA < promedioB)
			{
				return true;
			}
			return false;
			
		}		
		}
	
	public class PorLegajo :CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(Alumno a , Alumno b){
			int legajoA=a.Legajo;
			int legajoB= b.Legajo;
			if(legajoA == legajoB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMayor(Alumno a , Alumno b){
			int legajoA=a.Legajo;
			int legajoB= b.Legajo;
			if(legajoA > legajoB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMenor(Alumno a , Alumno b){
			int legajoA=a.Legajo;
			int legajoB= b.Legajo;
			if(legajoA < legajoB)
			{
				return true;
			}
			return false;
		}
	}
}
