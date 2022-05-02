/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 2/5/2022
 * Hora: 14:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Command.
	/// </summary>
	public class OrdenInicio:OrdenEnAula1
	{
		Aula aula;
		private static int vecesInvocada=0;
		
		public  OrdenInicio(Aula a){
			aula=a;
		}
		
		public void ejecutar( ){
			if(vecesInvocada==0)
			{aula.comenzar();}
			vecesInvocada++;
		}
		
		
	}
	
	public class OrdenAulaLlena:OrdenEnAula1
	{
		Aula aula;
		
		public  OrdenAulaLlena(Aula a){
			aula=a;
		}
		
		public void ejecutar( ){
			Console.WriteLine("Se lleno el aula");
			aula.claseLista();
		}
		
		
	}
	
	public class OrdenLlegaAlumno:OrdenEnAula2
	{
		Aula aula;
		
		public  OrdenLlegaAlumno(Aula a){
			aula=a;
		}
		
		public void ejecutar(Comparable alumno ){
			aula.nuevoAlumno(  ((IAlumno)alumno)  );
		}
		
		
	}
}
