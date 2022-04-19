/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 19/4/2022
 * Hora: 11:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Comparables.
	/// </summary>
	public class Numero : Comparable
	{
		private int valor;
		
		
		public Numero(int num){
			this.valor=num;
		}
		
		public int getValor{
			get {
				return valor;
			}
		}
		
		public bool sosIgual(Comparable c){
//			Numero n = (Numero) x;
//			if(n.getValor == valor)
//				return true;
//			return false;
			
			return this.getValor == ((Numero)c).getValor;
		}
		
			public bool sosMenor (Comparable c){
//			Numero n = (Numero) x;
//			if(n.getValor > this.valor)
//				return true;
//			return false;
			
			return this.getValor < ((Numero)c).getValor;
		}
			public bool sosMayor(Comparable c){
//			Numero n= (Numero) x;
//			if(n.getValor < this.valor)
//				return true;
//			return false;
			return this.getValor > ((Numero)c).getValor;
		}
		
		//Implementar para el writeLine 
		override public string ToString(){
			return ("Numero: "+" " +this.getValor.ToString());
		}
		
		
		
	}
	
	public class Persona : Comparable{
		string nombre;
		int dni;
		public Persona(string n, int d){
			nombre=n;
			dni=d;
		}
		public string getNombre{
			get{return nombre;}
		}
		public int getDni{
			get{return dni;}
		}
		
		
		virtual public bool sosIgual(Comparable x){
			return this.getDni == ((Persona)x).getDni;
		}
	
		virtual public bool sosMenor (Comparable x){
			return this.getDni < ((Persona)x).getDni;
		}
		virtual public bool sosMayor (Comparable x){
			return this.getDni > ((Persona)x).getDni;
		}
		
		override public string ToString(){
			return "Nombre: "+" "+this.getNombre;
		}
	}
	
	public class Alumno:Persona{
		private int legajo,promedio;
		
		//Paso 3 - Modificar el contexto. Strategy
		
		//3.1 Conposicion entre contexto y estrategia
		private CompararAlumnos estrategia; //Patron Strategy- variable para elegir el algoritmo de comparacion
		
		public Alumno(string n,int d,int l,int p):base(n,d)
		{
			legajo=l;
			promedio=p;
			
			//3.2 Crear un estrategia por defecto
			estrategia= new PorPromedio();  //Comparacion por Legajo por defecto. Antiguedad
		}
		public int Legajo{
			get{return legajo;}
		}
		public int Promedio{
			get{return promedio;}
		}
		
		
		//Patron Strategy. Metodo para cambiar el algoritmo de comparacion
		//3.3 Mecanismo para cambiar estrategia
		public void cambiarEstrategia(CompararAlumnos a){
			estrategia=a; 
		}
		
		//Ejercicio 18
		//Paso 4-Delegar la responsabilidad a la estrategia
		override public bool sosIgual(Comparable x){
//			return this.getLegajo == ((Alumno)x).getLegajo;			
			return estrategia.compararIgual(this,((Alumno)x));  //Con Patron Strategy delega la tarea de comparacion a la estrategia.
		}
		override public bool sosMenor(Comparable x){
			//return this.getLegajo < ((Alumno)x).getLegajo;
			return estrategia.compararMenor(this,((Alumno)x));  //Con Patron Strategy delega la tarea de comparacion a la estrategia.
							
		}
		override public bool sosMayor(Comparable x){
//			return this.getLegajo > ((Alumno)x).getLegajo;	
			return estrategia.compararMayor(this,((Alumno)x));  //Con Patron Strategy delega la tarea de comparacion a la estrategia.		
		}
		
		/*Esto nos evita tener que utilizar multiples If's. Por ejemplo : If por legajo,if por dni,etc.
		Tambien nos facilita a la hora de agregar otro algoritmo de comparacion,ya que no modifica en nada al codigo ya creado. Solo
		 tendriamos que modificar la estartegia del algrotimo*/

			override public string ToString(){
			return ("Nombre: "+this.getNombre+"| Dni: "+this.getDni.ToString()+"| Legajo: "+this.Legajo.ToString()+"| Promedio: "+this.Promedio.ToString() );
		}
				
	}
	
	public class ClaveValor:Comparable{
		private Comparable clave;
		private Comparable valor;
		
	
		
		
		public ClaveValor(Comparable cla,Comparable val){
			clave=cla;
			valor=val;
		}
		public Comparable Valor{
			get{
				return valor;
			}
			set{
				valor=value;
			}
		}
		public Comparable Clave
		{
		get{return clave;}
		set{clave=value;}
		
		}
		virtual public bool sosIgual(Comparable x){
			
			
				
			return valor .sosIgual(((ClaveValor)x).Valor);
		}
	
		virtual public bool sosMenor (Comparable x){
			
			return valor .sosMenor(((ClaveValor)x).Valor);
			
		}
		
		virtual public bool sosMayor (Comparable x){
			return valor .sosMayor(((ClaveValor)x).Valor);
		}
		
		override public string ToString(){
			//Solo imprimo Valor
			return ("Clave: "+clave.ToString()+" " +"valor: "+valor.ToString());
		}
		
		
	}

}
