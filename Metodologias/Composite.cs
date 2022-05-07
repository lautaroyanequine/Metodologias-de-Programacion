/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 7/5/2022
 * Hora: 14:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1
{
	/// <summary>
	/// Description of Composite.
	/// </summary>
	public class AlumnoCompuesto:Alumno
	{
		Cola hijos;
		
		public AlumnoCompuesto(string n ,int d,int l,int p):base(n,d,l,p){
			hijos= new Cola();
		}
		
		public void agregarHijo( IAlumno a){
			hijos.agregar(a);
		}
		
		
		override public String  getNombre(){
			string ae= " ";
			foreach(IAlumno a in hijos.Datos){
				ae+=" "+ a.getNombre()+",";
			}
			return ae;
		}
		
		public override int responderPregunta(int pregunta)
		{
			int[] respuestas=new int[] {0,1,2,3,4,5,6,7,8,9,10};
			int[] conRespuestas= new int[10];
			int max=conRespuestas[0];
			int indice=0;
			
			foreach(IAlumno a in hijos.Datos){
				int aux=a.responderPregunta(pregunta);
				conRespuestas[aux-1]+=1;
			}

			for (int i=1; i<10;i++)
			{
				if(conRespuestas[i] > max)
					indice=i;
			}
			return respuestas[indice];
			
		}
		
		public override void setCalificacion(int c)
		{
			foreach(IAlumno a in hijos.Datos){
				a.setCalificacion(c);
			}
		}
		
		public override int getCalificacion()
		{
			return ((IAlumno)hijos.maximo()).getCalificacion();
		}
		
		public override bool sosIgual(Comparable x)
		{
			return hijos.contiene(x);
		}
		
		public override bool sosMayor(Comparable x)
		{
			return hijos.maximo().sosMayor(x);
		}
		public override bool sosMenor(Comparable x)
		{
			return hijos.maximo().sosMenor(x);
		}
		
		
				

		
		
	}
}
