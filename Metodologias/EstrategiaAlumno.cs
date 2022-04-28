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
		public bool compararIgual(IAlumno a,IAlumno b){
			string nombreA=a.getNombre();
			string nombreB= b.getNombre();
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == 0)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMayor(IAlumno a,IAlumno b){
			string nombreA=a.getNombre();
			string nombreB= b.getNombre();
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == -1)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMenor(IAlumno a,IAlumno b){
			string nombreA=a.getNombre();
			string nombreB= b.getNombre();
			if(nombreA.ToLower().CompareTo(nombreB.ToLower()) == 1)
			{
				return true;
			}
			return false;
			
		}
	}
	
	public class PorDni:CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(IAlumno a,IAlumno b){
			int dniA=a.getDni();
			int dniB= b.getDni();
			if(dniA == dniB)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMayor(IAlumno a,IAlumno b){
			int dniA=a.getDni();
			int dniB= b.getDni();
			if(dniA > dniB)
			{
				return true;
			}
			return false;

		

	}

		public bool compararMenor(IAlumno a,IAlumno b){
			int dniA=a.getDni();
			int dniB= b.getDni();
			if(dniA < dniB)
			{
				return true;
			}
			return false;

		

	}		
	
		

		

	}
	
	public class PorPromedio:CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(IAlumno a,IAlumno b){
			int promedioA=a.getPromedio();
			int promedioB= b.getPromedio();
			if(promedioA == promedioB)
			{
				return true;
			}
			return false;
			
		}

		public bool compararMayor(IAlumno a,IAlumno b){
			int promedioA=a.getPromedio();
			int promedioB= b.getPromedio();
			if(promedioA > promedioB)
			{
				return true;
			}
			return false;
			
		}
		
		public bool compararMenor(IAlumno a,IAlumno b){
			int promedioA=a.getPromedio();
			int promedioB= b.getPromedio();
			if(promedioA < promedioB)
			{
				return true;
			}
			return false;
			
		}		
		}
	
	public class PorLegajo :CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(IAlumno a , IAlumno b){
			int legajoA=a.getLegajo();
			int legajoB= b.getLegajo();
			if(legajoA == legajoB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMayor(IAlumno a , IAlumno b){
			int legajoA=a.getLegajo();
			int legajoB= b.getLegajo();
			if(legajoA > legajoB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMenor(IAlumno a , IAlumno b){
			int legajoA=a.getLegajo();
			int legajoB= b.getLegajo();
			if(legajoA < legajoB)
			{
				return true;
			}
			return false;
		}
	}
	
	public class PorCalificacion :CompararAlumnos{
		
		// Cada clase que implemente CompararAlumnos implementa su propia versión del algoritmo de comparacion. 
		public bool compararIgual(IAlumno a , IAlumno b){
			int calificacionA=a.getCalificacion();
			int calificacionB= b.getCalificacion();
			if(calificacionA == calificacionB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMayor(IAlumno a , IAlumno b){
			int calificacionA=a.getCalificacion();
			int calificacionB= b.getCalificacion();
			if(calificacionA > calificacionB)
			{
				return true;
			}
			return false;
		}
		
		public bool compararMenor(IAlumno a , IAlumno b){
			int calificacionA=a.getCalificacion();
			int calificacionB= b.getCalificacion();
			if(calificacionA < calificacionB)
			{
				return true;
			}
			return false;
		}
	}
}
