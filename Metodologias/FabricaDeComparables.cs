/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 20/4/2022
 * Hora: 08:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	/// 
	
	
	//Paso 1 Clase abstracta de fabricas
	
	abstract public class FabricaDeComparables:IFabricaDeComparable {
		//Paso 1.1 Metodo de clase.Static
		
		public static Comparable crearAleatorio(int queProducto){
			//Crear una fabrica concreta que sepa crear el tipo de producto que nos piden
			FabricaDeComparables fabrica = null;
			switch(queProducto){
					//No crea productos,sabe y crea la fabrica concreta que sabe crear ese producto
					case 1: fabrica = new FabricaDeNumeros(); break;
					case 2: fabrica = new FabricaDePersonas(); break;
					case 3: fabrica = new FabricaDeAlumnos(); break;
					case 4 : fabrica = new FabricaDeVendedores(); break;
					case 5: fabrica = new FabricaDeAlumnosMuyEstudioso(); break;
				
			}
			return fabrica.crearAleatorio();
		}
		public static Comparable crearPorTeclado(int queProducto){
			//Crear una fabrica concreta que sepa crear el tipo de producto que nos piden
			FabricaDeComparables fabrica = null;
			switch(queProducto){
					//No crea productos,sabe y crea la fabrica concreta que sabe crear ese producto
					case 1: fabrica = new FabricaDeNumeros(); break;
					case 2: fabrica = new FabricaDePersonas(); break;
					case 3: fabrica = new FabricaDeAlumnos(); break;
					case 4: fabrica = new FabricaDeVendedores(); break;
			}
			return fabrica.crearPorTeclado();
		}
		
		//Paso 1.2 Metodo de instancia
		
		
		abstract public Comparable crearAleatorio(); //Toda jerarquia completa tiene que saber crear el producto
		abstract public Comparable crearPorTeclado();
	}
	//Gemelos Fabricas y productos- uno a uno
	//Paso 2. SubClases de Fabricas
	
	public class FabricaDeNumeros:FabricaDeComparables{
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			Numero n= new Numero(g.numeroAleatorio(100));
			return n;
		}
		override public Comparable crearPorTeclado(){
			LectorDeDatos l = new LectorDeDatos();
			Console.WriteLine("Ingrese un numero: ");
			Numero n = new Numero(l.numeroPorTeclado());
			return n;
		}
	}
	public class FabricaDePersonas:FabricaDeComparables{
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			Persona a= new Persona(g.stringAleatorio(8),g.numeroAleatorio(50000000));
			return a;
		}
		override public Comparable crearPorTeclado(){
			LectorDeDatos l = new LectorDeDatos();
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= l.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= l.numeroPorTeclado();
			Persona a = new Persona(nombre,dni);
			return a;
		}
		
	}
	public class FabricaDeAlumnos:FabricaDeComparables{
		protected Alumno a1,a2;
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			a1= new Alumno(g.nombresAleatorio(),g.numeroAleatorio(50000000),g.numeroAleatorio(8000),g.numeroAleatorio(10));
			return a1;
		}
		override public Comparable crearPorTeclado(){
			LectorDeDatos l = new LectorDeDatos();
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= l.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= l.numeroPorTeclado();
			Console.WriteLine("Ingrese Legajo: ");
			int legajo= l.numeroPorTeclado();	
			Console.WriteLine("Ingrese Promedio: ");
			int promedio= l.numeroPorTeclado();
			a2 = new Alumno(nombre,dni,legajo,promedio);
			return a2;
		}
	}
	public class FabricaDeAlumnosMuyEstudioso:FabricaDeComparables{
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			AlumnoMuyEstudioso a= new AlumnoMuyEstudioso(g.nombresAleatorio(),g.numeroAleatorio(50000000),g.numeroAleatorio(8000),g.numeroAleatorio(10));
			return a;
		}
		override public Comparable crearPorTeclado(){
			LectorDeDatos l = new LectorDeDatos();
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= l.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= l.numeroPorTeclado();
			Console.WriteLine("Ingrese Legajo: ");
			int legajo= l.numeroPorTeclado();	
			Console.WriteLine("Ingrese Promedio: ");
			int promedio= l.numeroPorTeclado();
			AlumnoMuyEstudioso a = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
			return a;
		}
	}
	
	public class StudentsFactory:FabricaDeAlumnos{
		
		override public Comparable crearAleatorio(){
			Alumno a;
			a=((Alumno)base.crearAleatorio());
			
			return a;
		}
		override public Comparable crearPorTeclado(){
			
		}
	}
	public class FabricaDeVendedores:FabricaDeComparables{
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			Vendedor a= new Vendedor(g.nombresAleatorio(),g.numeroAleatorio(50000000),g.numeroAleatorio(80000));
			return a;
		}
		override public Comparable crearPorTeclado(){
			LectorDeDatos l = new LectorDeDatos();
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= l.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= l.numeroPorTeclado();
			Console.WriteLine("Ingrese Sueldo Basico: ");
			int sb= l.numeroPorTeclado();
			Vendedor a = new Vendedor(nombre,dni,sb);
			return a;
		}
		
	}
}
