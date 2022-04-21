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
	public class GeneradorDeDatosAleatorios
		
	{
		     
		static Random randomUnicoDeInstancia = new Random(); 
		static Random randomUnicoDeInstancia2 = new Random();
    	static Random randomUnicoDeInstancia3= new Random();
    	

		public int numeroAleatorio(int max)
		{
			
			return randomUnicoDeInstancia3.Next(max+1);
		}
		
		public string stringAleatorio(int cant){
			string[] abecedario = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
			string a= " ";
			for(int i=0;i<cant;i++)
			{
				if(i==0)
				{
					a+=abecedario[randomUnicoDeInstancia2.Next(26)];
				}
				else
				a=a+abecedario[randomUnicoDeInstancia2.Next(27,52)];
			}
			return a;
			
		}
		
		public string nombresAleatorio(){

			string[] nombres= { "juan", "pablo", "Julian", "jose", "Alberto","Lautaro","Pedro","Agustin","Jeremias","Martin"};
			string[] apellidos = { "sanchez", "perez", "lopez", "zelaya", "alvarez","Yanequine","Martinez"};
			string a = " ";
			a= nombres[randomUnicoDeInstancia.Next(9)]+" " +apellidos[randomUnicoDeInstancia.Next(7)];
			return a;
		
	}
	}
	
	
	public class LectorDeDatos{
		
		public int numeroPorTeclado(){
			int n= int.Parse(Console.ReadLine());
			return n;
		}
		
		public string stringPorTeclado(){
			string n= Console.ReadLine();
			return n;
		}
	}
}

	


