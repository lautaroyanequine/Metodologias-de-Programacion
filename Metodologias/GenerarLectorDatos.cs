/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 20/4/2022
 * Hora: 09:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Clases.
	/// </summary>
	/// 
	
	//Paso 2 q los manejadores concretos hereden de la superclase
	public class GeneradorDeDatosAleatorios: Manejador
		
	{
		public GeneradorDeDatosAleatorios(Manejador m) : base (m){ }
		     
		static Random randomUnicoDeInstancia = new Random();
    	

		override public int numeroAleatorio(int max)
		{
			
			return randomUnicoDeInstancia.Next(max+1);
		}
		
		override public string stringAleatorio(int cant){
			string[] abecedario = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
			string a= " ";
			for(int i=0;i<cant;i++)
			{
				if(i==0)
				{
					a+=abecedario[randomUnicoDeInstancia.Next(26)];
				}
				else
				a=a+abecedario[randomUnicoDeInstancia.Next(27,52)];
			}
			return a;
			
		}
		
		override public string nombresAleatorio(){

			string[] nombres= { "juan", "pablo", "Julian", "jose", "Alberto","Lautaro","Pedro","Agustin","Jeremias","Martin"};
			string[] apellidos = { "sanchez", "perez", "lopez", "zelaya", "alvarez","Yanequine","Martinez"};
			string a = " ";
			a= nombres[randomUnicoDeInstancia.Next(9)]+" " +apellidos[randomUnicoDeInstancia.Next(7)];
			return a;
		
	}
	}
	
	
	public class LectorDeDatos: Manejador{
		public LectorDeDatos(Manejador m) : base (m){ }
		override public int numeroPorTeclado(){
			int n= int.Parse(Console.ReadLine());
			return n;
		}
		
		override public string stringPorTeclado(){
			string n= Console.ReadLine();
			return n;
		}
	}
	
	//Patron Chain
	
	//Paso 1 manejador
	
	abstract public class Manejador{
		Manejador sucesor = null;
		
		public Manejador(Manejador s){
			sucesor=s;
		}
		
		virtual public int numeroAleatorio(int max) {
			if(sucesor != null) 
				return sucesor.numeroAleatorio(max);
			return 0;
		}
		
		virtual public string stringAleatorio(int cant) {
			if(sucesor != null) 
				return sucesor.stringAleatorio(cant);
			return " ";
		}
		virtual public string nombresAleatorio() {
			if(sucesor != null) 
				return sucesor.nombresAleatorio();
			return  "";
		}
		virtual public int numeroPorTeclado() {
			if(sucesor != null) 
				return sucesor.numeroPorTeclado();
			return 0;
		}
		
		virtual public string stringPorTeclado() {
			if(sucesor != null) 
				return sucesor.stringPorTeclado();
			return "";
		}		
		
		virtual public  double numeroDesdeArchivo(double max) {
			if(sucesor != null) 
				return sucesor.numeroDesdeArchivo(max);
			return 0;
		}
		
		virtual public  string stringDesdeArchivo(int cant){ 
			if(sucesor != null) 
				return sucesor.stringDesdeArchivo(cant);
			return "";
		}
		
		
	}
}

	


