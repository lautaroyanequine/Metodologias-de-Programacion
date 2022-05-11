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
	/// 
	//Componete -> interface IAlumno
	//Hoja-> Alumno
	public class AlumnoCompuesto:IAlumno
	{
		Cola hijos;
		
//		public AlumnoCompuesto(string n ,int d,int l,int p):base(n,d,l,p){
//			hijos= new Cola();
//		}
		public AlumnoCompuesto(){
			hijos= new Cola();
		}
		public void agregarHijo( IAlumno a){
			hijos.agregar(a);
		}
		
		
	 public String  getNombre(){
			string ae= " ";
			foreach(IAlumno a in hijos.Datos){
				ae+=" "+ a.getNombre()+",";
			}
			return ae;
		}
		
		public  int responderPregunta(int pregunta)
		{
			int[] respuestas=new int[] {0,1,2,3,4,5,6,7,8,9,10};
			int[] conRespuestas= new int[10];
			
			int indice=0;
			
			foreach(IAlumno a in hijos.Datos){
				int aux=a.responderPregunta(pregunta);
				conRespuestas[aux]+=1;
			}
			int max=conRespuestas[0];
			for (int i=1; i<10;i++)
			{
				if(conRespuestas[i] > max)
					indice=i;
			}
			return respuestas[indice];
			
		}
		
		public  void setCalificacion(int c)
		{
			foreach(IAlumno a in hijos.Datos){
				a.setCalificacion(c);
			}
		}
		
		public  int getCalificacion()
		{
			return ((IAlumno)hijos.maximo()).getCalificacion();
		}
		
		public  bool sosIgual(Comparable x)
		{
			return hijos.contiene(x);
		}
		
		public  bool sosMayor(Comparable x)
		{
			return hijos.maximo().sosMayor(x);
		}
		public  bool sosMenor(Comparable x)
		{
			return hijos.maximo().sosMenor(x);
		}
		
		public int getLegajo(){
			return ( (IAlumno)hijos.maximo() ).getLegajo();
		}
		public void setLegajo(int c){
			foreach(IAlumno a in hijos.Datos){
				a.setLegajo(c);
			}
		}
		
		public int getDni(){
			return ( (IAlumno)hijos.maximo() ).getDni();
		}
		public void setDni(int d){
				foreach(IAlumno a in hijos.Datos){
				a.setDni(d);
			}
		}
		
		
		public int getPromedio(){
			return ( (IAlumno)hijos.maximo() ).getPromedio();
		}
		public void setPromedio(int p){
			foreach(IAlumno a in hijos.Datos){
				a.setPromedio(p);}
		}

		public void setNombre(string n){
		
		}

		public void cambiarEstrategia(CompararAlumnos ea){
				foreach(IAlumno a in hijos.Datos){
				a.cambiarEstrategia(ea);}
		}
		
		public string mostrarCalificacion(){
			return ("Nombres: "+this.getNombre()+"  "+"| Calificacion: "+((IAlumno)hijos.maximo()).getCalificacion().ToString() );
		}
		
				

		
		
	}
}
