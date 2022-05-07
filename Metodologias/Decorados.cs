/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 27/4/2022
 * Hora: 09:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Decorados.
	/// </summary>
	/// 
	//Paso 2 crear Jerarquia de decorados
	abstract public class DecoradorAlumno:IAlumno,Comparable{
		//paso 2.1 Crear la composicion
		protected IAlumno adicional;
		
		public DecoradorAlumno(IAlumno a ){
			//Todos los decoradores concreto va a estar compuesto por otro decorador/componente
			adicional=a;
		}
		
		//Paso 2.2 Redirigir la peticion al adicional
		//Todos los metodos que puse en la interface IAlumno implemnetarlo y van dirigidos al adicional
		virtual public void cambiarEstrategia(CompararAlumnos a){
			 adicional.cambiarEstrategia(a);
		}
		virtual public bool sosIgual(Comparable x){
			return adicional.sosIgual(x);
		}
		virtual public bool sosMenor(Comparable x){
			return adicional.sosMenor(x);
		}
		virtual public bool sosMayor(Comparable x){
			return adicional.sosMayor(x);
		}
		virtual public int getLegajo(){
			return adicional.getLegajo();
		}
		virtual public void setLegajo(int c){
			adicional.setLegajo(c);
		}
		virtual public int getDni(){
			return adicional.getDni();
		}
		virtual public void setDni(int c){
			adicional.setDni(c);
		}
		virtual public int getPromedio(){
			return adicional.getPromedio();
		}
		virtual public void setPromedio(int c){
			adicional.setPromedio(c);
		}
		virtual public string getNombre(){
			return adicional.getNombre();
		}
		virtual public void setNombre(string c){
			adicional.setNombre(c);
		}
		virtual public int getCalificacion(){
			return adicional.getCalificacion();
		}
		virtual public void setCalificacion(int c){
			adicional.setCalificacion(c);
		}
		virtual public int responderPregunta(int pregunta){
			return adicional.responderPregunta(pregunta);
		}
		virtual public string mostrarCalificacion(){
			return adicional.mostrarCalificacion();
		}
		virtual public string ToString(){
			return adicional.ToString();
		}
	}
	
	//Paso 3 crear decorados concretos
	

	public class DecoradorLegajo:DecoradorAlumno{
		
		public DecoradorLegajo(IAlumno a):base(a){
			
		}
		
		//Lo unico que tiene q hacer es implemnetar el meodo que quiere decorar
		
		override public string  mostrarCalificacion(){
			string resultado= base.mostrarCalificacion();
			//Comportamiento adicional
			resultado= resultado +" "+"("+ adicional.getLegajo()+")";
			return resultado;
		}
	} 
	
	public class DecoradorLetras:DecoradorAlumno{
		
	public DecoradorLetras(IAlumno a):base(a){
			
		}
		
		//Lo unico que tiene q hacer es implemnetar el meodo que quiere decorar
		
		override public string  mostrarCalificacion(){
			string resultado= base.mostrarCalificacion();
			//Comportamiento adicional
			string[] letras= new string[]{"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"};
			
			resultado= resultado+" " +"("+(letras[adicional.getCalificacion()])+")";
			
			return resultado;
		}
	} 
	
	public class DecoradorPromocion:DecoradorAlumno{
		
	public DecoradorPromocion(IAlumno a):base(a){
			
		}
		
		//Lo unico que tiene q hacer es implemnetar el meodo que quiere decorar
		
		override public string  mostrarCalificacion(){
			string resultado= base.mostrarCalificacion();
			//Comportamiento adicional
			if(adicional.getCalificacion()>=7)
			{
				resultado+="(PROMOCIONADO)";
				
			}
			else if( adicional.getCalificacion()<7 && adicional.getCalificacion()>=4)
			{
				resultado+="(APROBADO)";
			}
			else{
				resultado+="(DESAPROBADO)";
			}
			return resultado;
			
			
		}
	} 
	
	public class DecoradorAsterisco:DecoradorAlumno{
		
	public DecoradorAsterisco(IAlumno a):base(a){
			
		}
		
		//Lo unico que tiene q hacer es implemnetar el meodo que quiere decorar
		
		override public string  mostrarCalificacion(){
			string resultado= base.mostrarCalificacion();
			
			resultado= "***********************************************************************************************************\n" +
				"*   "+resultado+"  *\n   \n"+"***********************************************************************************************************";
			
			return resultado;
		}
	} 
	
	public class DecoradorListado:DecoradorAlumno{
		
		private static int contador;
	public DecoradorListado(IAlumno a):base(a){
			contador=1;
		}
		
		//Lo unico que tiene q hacer es implemnetar el meodo que quiere decorar
		
		override public string  mostrarCalificacion(){
			string resultado= base.mostrarCalificacion();
			
			resultado= contador.ToString()+") "+resultado;
			contador++;
			return resultado;
		}
	} 
	
}
