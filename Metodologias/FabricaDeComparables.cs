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
		
		protected Manejador generador;
		protected Manejador lector;
		protected Manejador lectorArchivos ;
		
		public FabricaDeComparables(){
			generador = new GeneradorDeDatosAleatorios(null);
			lector = new LectorDeDatos(generador);
			lectorArchivos = new LectorDeArchivos(lector);
		}
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
					case 6: fabrica = new FabricaDeAlumnosDecorados(); break;
					case 7: fabrica = new FabricaDeAlumnosMuyEstudiosoDecorados(); break;
					case 8: fabrica = new FabricaDeProxyAlumnos(); break;
					case 9: fabrica = new FabricaDeAlumnosCompuesto(); break;
				
				
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
					case 5: fabrica = new FabricaDeAlumnosMuyEstudioso(); break;
					case 6: fabrica = new FabricaDeAlumnosDecorados(); break;
					case 7: fabrica = new FabricaDeAlumnosMuyEstudiosoDecorados(); break;
					case 8: fabrica = new FabricaDeProxyAlumnos(); break;
					case 9: fabrica = new FabricaDeAlumnosCompuesto(); break;
			}
			return fabrica.crearPorTeclado();
		}
		
		public static Comparable crearAleatorioDesdeArchivo(int queProducto){
			//Crear una fabrica concreta que sepa crear el tipo de producto que nos piden
			FabricaDeComparables fabrica = null;
			switch(queProducto){
					//No crea productos,sabe y crea la fabrica concreta que sabe crear ese producto
					case 1: fabrica = new FabricaDeNumeros(); break;
					case 2: fabrica = new FabricaDePersonas(); break;
					case 3: fabrica = new FabricaDeAlumnos(); break;
					case 4 : fabrica = new FabricaDeVendedores(); break;
					case 5: fabrica = new FabricaDeAlumnosMuyEstudioso(); break;
					case 6: fabrica = new FabricaDeAlumnosDecorados(); break;
					case 7: fabrica = new FabricaDeAlumnosMuyEstudiosoDecorados(); break;
					case 8: fabrica = new FabricaDeProxyAlumnos(); break;
					case 9: fabrica = new FabricaDeAlumnosCompuesto(); break;
				
				
			}
			return fabrica.crearAleatorio();
		}
		
		//Paso 1.2 Metodo de instancia
		
		
		abstract public Comparable crearAleatorio(); //Toda jerarquia completa tiene que saber crear el producto
		abstract public Comparable crearPorTeclado();
		abstract public Comparable crearAleatorioDesdeArchivo();
	}
	//Gemelos Fabricas y productos- uno a uno
	//Paso 2. SubClases de Fabricas
	
	public class FabricaDeNumeros:FabricaDeComparables{
		override public Comparable crearAleatorio(){
			//Paso 3 implementarlo en el cliente
			Numero n= new Numero(lectorArchivos.numeroAleatorio(100));
			return n;
		}
		override public Comparable crearPorTeclado(){
			Manejador g=new LectorDeDatos(null);
			g=new GeneradorDeDatosAleatorios(g);
			Console.WriteLine("Ingrese un numero: ");
			Numero n = new Numero(g.numeroPorTeclado());
			return n;
		}
		override public Comparable crearAleatorioDesdeArchivo(){
			Numero n= new Numero((int)(lectorArchivos.numeroDesdeArchivo(100)));
			return n;
		}
	}
	public class FabricaDePersonas:FabricaDeComparables{
		override public Comparable crearAleatorio(){
		
			Persona a= new Persona(lectorArchivos.nombresAleatorio(),lectorArchivos.numeroAleatorio(50000000));
			return a;
		}
		override public Comparable crearPorTeclado(){


			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= lectorArchivos.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= lectorArchivos.numeroPorTeclado();
			Persona a = new Persona(nombre,dni);
			return a;
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){

			Persona a= new Persona(lectorArchivos.stringDesdeArchivo(10),(int)(lectorArchivos.numeroDesdeArchivo(50000000)));
			return a;
		}
		
	}
	public class FabricaDeAlumnos:FabricaDeComparables{
		protected Alumno a1,a2;
		override public Comparable crearAleatorio(){
	
			a1= new Alumno(lectorArchivos.nombresAleatorio(),lectorArchivos.numeroAleatorio(50000000),lectorArchivos.numeroAleatorio(8000),lectorArchivos.numeroAleatorio(10));
			return a1;
		}
		override public Comparable crearPorTeclado(){
	
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= lectorArchivos.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= lectorArchivos.numeroPorTeclado();
			Console.WriteLine("Ingrese Legajo: ");
			int legajo= lectorArchivos.numeroPorTeclado();	
			Console.WriteLine("Ingrese Promedio: ");
			int promedio= lectorArchivos.numeroPorTeclado();
			a2 = new Alumno(nombre,dni,legajo,promedio);
			return a2;
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){


			a1= new Alumno(lectorArchivos.stringDesdeArchivo(10),(int)(lectorArchivos.numeroDesdeArchivo(50000000)),(int)(lectorArchivos.numeroDesdeArchivo(8000)),(int)(lectorArchivos.numeroDesdeArchivo(10)));
			return a1;
		}
	}
	
	public class FabricaDeAlumnosCompuesto:FabricaDeComparables{
			override public Comparable crearAleatorio(){
			
			return new AlumnoCompuesto();
		}
		override public Comparable crearPorTeclado(){
			return new AlumnoCompuesto();
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){
			
			return new AlumnoCompuesto();
		}
	}
	

	public class FabricaDeAlumnosMuyEstudioso:FabricaDeComparables{
		override public Comparable crearAleatorio(){
		
			AlumnoMuyEstudioso a= new AlumnoMuyEstudioso(lectorArchivos.nombresAleatorio(),lectorArchivos.numeroAleatorio(50000000),lectorArchivos.numeroAleatorio(8000),lectorArchivos.numeroAleatorio(10));
			return a;
		}
		override public Comparable crearPorTeclado(){
			
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= lectorArchivos.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= lectorArchivos.numeroPorTeclado();
			Console.WriteLine("Ingrese Legajo: ");
			int legajo= lectorArchivos.numeroPorTeclado();	
			Console.WriteLine("Ingrese Promedio: ");
			int promedio= lectorArchivos.numeroPorTeclado();
			AlumnoMuyEstudioso a = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
			return a;
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){

			AlumnoMuyEstudioso a= new AlumnoMuyEstudioso(lectorArchivos.stringDesdeArchivo(10),(int)(lectorArchivos.numeroDesdeArchivo(50000000)),(int)(lectorArchivos.numeroDesdeArchivo(8000)),(int)(lectorArchivos.numeroDesdeArchivo(10)));
			return a;
		}
	}
	public class FabricaDeProxyAlumnos:FabricaDeComparables{
		private AlumnoProxy a1,a2;
		override public Comparable crearAleatorio(){
			
			a1= new AlumnoProxy(lectorArchivos.nombresAleatorio(),lectorArchivos.numeroAleatorio(50000000),lectorArchivos.numeroAleatorio(8000),lectorArchivos.numeroAleatorio(10),6);
			return a1;
		}
		override public Comparable crearPorTeclado(){

			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= lectorArchivos.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= lectorArchivos.numeroPorTeclado();
			Console.WriteLine("Ingrese Legajo: ");
			int legajo= lectorArchivos.numeroPorTeclado();	
			Console.WriteLine("Ingrese Promedio: ");
			int promedio= lectorArchivos.numeroPorTeclado();
			a2 = new AlumnoProxy(nombre,dni,legajo,promedio,3);
			return a2;
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){

		
			a1= new AlumnoProxy(
				lectorArchivos.stringDesdeArchivo(10), 
				Convert.ToInt32( lectorArchivos.numeroDesdeArchivo(503) ),
			 	Convert.ToInt32( lectorArchivos.numeroDesdeArchivo(83) ),
				Convert.ToInt32( lectorArchivos.numeroDesdeArchivo(12) ),
				 3);
			return a1;
		}
	}
/*	public class FabricaDeProxyAlumnosMuyEstudioso:FabricaDeComparables{
			override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			AlumnoMuyEstudiosoProxy a= new AlumnoMuyEstudiosoProxy(g.nombresAleatorio(),g.numeroAleatorio(50000000),g.numeroAleatorio(8000),g.numeroAleatorio(10));
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
			AlumnoMuyEstudiosoProxy a = new AlumnoMuyEstudiosoProxy(nombre,dni,legajo,promedio);
			return a;
		}
	}*/
	public class FabricaDeAlumnosDecorados:FabricaDeAlumnos{
		
		
		//tengo q retornar un IAlumno
		
		override public Comparable crearPorTeclado(){
		IAlumno final=((Alumno)base.crearPorTeclado());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );
			return decorador5;
			
		}
		override public Comparable crearAleatorio(){
			IAlumno final=((Alumno)base.crearAleatorio());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );

			
			
		
			return decorador5;
			
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){
			IAlumno final=((Alumno)base.crearAleatorioDesdeArchivo());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );

			
			
		
			return decorador5;
			
		}
	}
	
	public class FabricaDeAlumnosMuyEstudiosoDecorados:FabricaDeAlumnosMuyEstudioso{
		
		
		//tengo q retornar un IAlumno
		
		override public Comparable crearPorTeclado(){
			
			IAlumno final=((Alumno)base.crearPorTeclado());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );
			
			return decorador5;
			
		}
		override public Comparable crearAleatorio(){
			IAlumno final=((AlumnoMuyEstudioso)base.crearAleatorio());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );

			
			
		
			return decorador5;
			
		}
		
		override public Comparable crearAleatorioDesdeArchivo(){
			IAlumno final=((AlumnoMuyEstudioso)base.crearAleatorioDesdeArchivo());
			IAlumno decorador= new DecoradorLegajo( final);
			IAlumno decorador2= new DecoradorLetras( decorador );
			IAlumno decorador3= new DecoradorPromocion( decorador2 );
			IAlumno decorador4= new DecoradorListado( decorador3 );
			IAlumno decorador5= new DecoradorAsterisco(decorador4 );

			
			
		
			return decorador5;
			
		}
	}
	
	public class FabricaDeVendedores:FabricaDeComparables{
		override public Comparable crearAleatorio(){
		
			Vendedor a= new Vendedor(lectorArchivos.nombresAleatorio(),lectorArchivos.numeroAleatorio(50000000),lectorArchivos.numeroAleatorio(80000));
			return a;
		}
		override public Comparable crearPorTeclado(){
			Manejador l=new LectorDeDatos(null);
			l=new GeneradorDeDatosAleatorios(l);
			Console.WriteLine("Ingrese nombre y apellido: ");
			string nombre= l.stringPorTeclado();
			Console.WriteLine("Ingrese DNI: ");
			int dni= l.numeroPorTeclado();
			Console.WriteLine("Ingrese Sueldo Basico: ");
			int sb= l.numeroPorTeclado();
			Vendedor a = new Vendedor(nombre,dni,sb);
			return a;
		}
	
		override public Comparable crearAleatorioDesdeArchivo(){
	
			Vendedor a= new Vendedor(lectorArchivos.stringDesdeArchivo(10),(int)(lectorArchivos.numeroDesdeArchivo(50000000)),(int)(lectorArchivos.numeroDesdeArchivo(80000)));
			return a;
		}
		
	}
}
