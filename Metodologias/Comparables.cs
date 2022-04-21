/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 19/4/2022
 * Hora: 11:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

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
	
	public class Vendedor : Persona,IObservado{  //Sujeto o Observado
		int sueldoBaisco;
		double bonus;
		double monto;
			//Observer paso 2 Implementar el observado
		List<IObservador> observadores = new List<IObservador>();
		
		public Vendedor(string n,int d, int sb):base(n,d)
		{
			sueldoBaisco=sb;
			bonus=1;
		}
		
		public double Bonus{
			get{return bonus;}
		}
		public double Monto{
			get{return monto;}
			set{ monto=value;}
		}
		
		virtual public void venta(double mon)
		{

			 monto=mon;
			this.notificar();
		}
		
		public void aumentaBonus()
		{
			bonus=(bonus*1.1);
		}
		
		override public bool sosIgual(Comparable x){
			return this.Bonus == ((Vendedor)x).Bonus;			

		}
		override public bool sosMenor(Comparable x){
			return this.Bonus < ((Vendedor)x).Bonus;			
							
		}
		override public bool sosMayor(Comparable x){
			return this.Bonus > ((Vendedor)x).Bonus;			
		}
		
	
		
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		}
		public void eliminarObservador(IObservador o){
			observadores.Remove(o);
		}
		
		public void notificar(){
			foreach (IObservador o in observadores)
			{
				o.actualizar(this);
			}
		}
		
		override public string ToString(){
			return ("Nombre: "+this.getNombre+/*"| Dni: "+this.getDni.ToString()+/"| Sueldo Basico: "+this.sueldoBaisco.ToString()+"*/"| Bonus: "+this.bonus.ToString() );
		}
	}
	
	public class VendedorPauperrimo:Vendedor{
		
		public VendedorPauperrimo(string n,int d, int sb):base(n,d,sb)
		{
			
		}
		
		public void robar(){
			Console.WriteLine("Robando");
		}
		public void descansar(){
			Console.WriteLine("Descansando");
		}
		public void molestarALosCompañeros(){
			Console.WriteLine("Molestando");
		}
		
		override public void venta(double mon){
			if(mon < 500){
				this.robar();
				this.notificar();
				
			}
			if(mon >4000){
				this.descansar();
				this.notificar();
			}
			else{
				this.molestarALosCompañeros();
				this.notificar();
			}
		}
	}
	
	public class Gerente: Persona,IObservador{ //Observador
		Conjunto mejoresVendedores;
			public Gerente(string n,int d):base(n,d)
			{
				mejoresVendedores=new Conjunto();
			}
			
			public void venta(double monto, Vendedor vendedor)
			{
				if(monto > 5000)
				{
					mejoresVendedores.agregar(vendedor);
					vendedor.aumentaBonus();
				}
			}
			
			public void cerrar(){
				Semana1.Program.imprimirElementos(mejoresVendedores);
				
			}
			
			//Paso 3 Implemnetar observador
			
			public void actualizar(IObservado o){
				this.venta(((Vendedor)o).Monto,((Vendedor)o));
			}
	}
	
	public class Seguridad:Persona,IObservador{
		Conjunto vendedoresLadrones;
		public Seguridad(string n,int d):base(n,d){
			vendedoresLadrones=new Conjunto();
		}
		
		public void venta( double mon,Vendedor o)
		{
			if (mon<500)
				vendedoresLadrones.agregar(o);
				
		}
		
		public void reaccionar(){
			Console.WriteLine("Reacciona seguridad");
		}
		
		public void actualizar(IObservado o){
				this.venta(((Vendedor)o).Monto,((Vendedor)o));
			}
	}
	
	public class Cliente:Persona,IObservador{
		
		Conjunto vendedores;
		public Cliente(string n,int d):base(n,d){
			vendedores=new Conjunto();
		}
		
		public void venta( double mon,Vendedor o)
		{
			if (mon>4000)
				vendedores.agregar(o);
				
		}
		public void reaccionar(){
			Console.WriteLine("Reacciona Cliente");
		}
		public void actualizar(IObservado o){
			this.venta(((Vendedor)o).Monto,((Vendedor)o));
		}
	}
	
	public class Encargado:Persona,IObservador{
		Conjunto vendedores;
		public Encargado(string n,int d):base(n,d){
			vendedores=new Conjunto();
		}
		
		public void venta( double mon,Vendedor o)
		{
			if (mon<4000 && mon >500)
				vendedores.agregar(o);
				
		}
		public void reaccionar(){
			Console.WriteLine("Reacciona Encargado");
		}
		public void actualizar(IObservado o){
			this.venta(((Vendedor)o).Monto,((Vendedor)o));
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
