/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;


namespace Semana1
{
	public class LectorDeArchivos: Manejador {
		
		
		//Singleton Paso 1- Variable que guarda la unica instancia
		
		private static LectorDeArchivos unica =null;
		private StreamReader lector_de_archivos;
		
		//Paso 2 - Un metodo que me permita acceder a esa unica instancia.
		public static LectorDeArchivos getInstance(Manejador m){
			
			if(unica ==null){
				unica=new LectorDeArchivos(m);
			}
			return unica;
		}
		
		//Paso 3 Impédir new- crecar un constrtuctor privado(propio del lengujae)
		

			
		
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\lauta\Desktop\Unaj\Metodologias de Programación\Semana1\Metodologias\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		
		
		private LectorDeArchivos(Manejador m ):base(m){
			lector_de_archivos = new StreamReader(ruta_archivo);
		}
		
		override public double numeroDesdeArchivo(double max){
			string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		override public string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
	}
}
