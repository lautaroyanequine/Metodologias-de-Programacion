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
					case 6: fabrica = new FabricaDeAlumnosDecorados(); break;
					case 7: fabrica = new FabricaDeAlumnosMuyEstudiosoDecorados(); break;
					case 8: fabrica = new FabricaDeProxyAlumnos(); break;
				//	case 9: fabrica = new FabricaDeProxyAlumnosMuyEstudioso(); break;
				
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
				//	case 9: fabrica = new FabricaDeProxyAlumnosMuyEstudioso(); break;
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
	public class FabricaDeProxyAlumnos:FabricaDeComparables{
		private AlumnoProxy a1,a2;
		override public Comparable crearAleatorio(){
			GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
			a1= new AlumnoProxy(g.nombresAleatorio(),g.numeroAleatorio(50000000),g.numeroAleatorio(8000),g.numeroAleatorio(10),6);
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
			a2 = new AlumnoProxy(nombre,dni,legajo,promedio,3);
			return a2;
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
			//Mejorar este codigo
			IAlumno final=((Alumno)base.crearAleatorio());
			IAlumno a=((Alumno)base.crearAleatorio());
			string opcion;
		
			
			Console.WriteLine("¿Desea agregar un decorado al student? ");
			opcion =Console.ReadLine().ToUpper();
			if(opcion=="SI")
			{
				Console.WriteLine("Desea que el alumno sea decorado con Legajo(SI/NO): ");
				 string opcionLegajo =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Letras(SI/NO): ");
				 string opcionLetras =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Promocion(SI/NO): ");
				 string opcionPromocion =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Listado(SI/NO): ");
				 string opcionListado =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Asterisco(SI/NO): ");
				 string opcionAsterisco =Console.ReadLine().ToUpper();
				 
				 if(opcionLegajo=="SI"){
				 	IAlumno aux= new DecoradorLegajo(a);
				 	final=aux;
				 	if(opcionLetras=="SI")
				 	{
				 		IAlumno aux2= new DecoradorLetras(aux);
				 		final=aux2;
				 		if(opcionPromocion=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(aux2);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 }
				 else{
				 	if(opcionLetras=="SI")
				 	{
				 		IAlumno aux2= new DecoradorLetras(a);
				 		final=aux2;
				 		if(opcionPromocion=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(aux2);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 			
				 		}
				 		else{
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux2);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 	else{
				 		if(opcionListado=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(a);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 		else{
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(a);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 			else{
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(a);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 }
				 
				 
			}
			
		
			return final;
			
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
	}
	
	public class FabricaDeAlumnosMuyEstudiosoDecorados:FabricaDeAlumnosMuyEstudioso{
		
		
		//tengo q retornar un IAlumno
		
		override public Comparable crearPorTeclado(){
			
			
			IAlumno final=((AlumnoMuyEstudioso)base.crearAleatorio());
			IAlumno a=((AlumnoMuyEstudioso)base.crearAleatorio());
			string opcion;
		
			
			Console.WriteLine("¿Desea agregar un decorado al student? ");
			opcion =Console.ReadLine().ToUpper();
			if(opcion=="SI")
			{
				Console.WriteLine("Desea que el alumno sea decorado con Legajo(SI/NO): ");
				 string opcionLegajo =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Letras(SI/NO): ");
				 string opcionLetras =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Promocion(SI/NO): ");
				 string opcionPromocion =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Listado(SI/NO): ");
				 string opcionListado =Console.ReadLine().ToUpper();
				 Console.WriteLine("Desea que el alumno sea decorado con Asterisco(SI/NO): ");
				 string opcionAsterisco =Console.ReadLine().ToUpper();
				 
				 if(opcionLegajo=="SI"){
				 	IAlumno aux= new DecoradorLegajo(a);
				 	final=aux;
				 	if(opcionLetras=="SI")
				 	{
				 		IAlumno aux2= new DecoradorLetras(aux);
				 		final=aux2;
				 		if(opcionPromocion=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(aux2);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 }
				 else{
				 	if(opcionLetras=="SI")
				 	{
				 		IAlumno aux2= new DecoradorLetras(a);
				 		final=aux2;
				 		if(opcionPromocion=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(aux2);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 	else{
				 		if(opcionPromocion=="SI"){
				 			IAlumno aux3 = new DecoradorPromocion(a);
				 			final=aux3;
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(aux3);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 		}
				 		else{
				 			if(opcionListado=="SI"){
				 				IAlumno aux4= new DecoradorListado(a);
				 				final=aux4;
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(aux4);
				 					final=aux5;
				 				}
				 			}
				 			else{
				 				if(opcionAsterisco=="SI"){
				 					IAlumno aux5= new DecoradorAsterisco(a);
				 					final=aux5;
				 				}
				 			}
				 		}
				 	}
				 }
				 
				 
			}
			
		
			return final;
			
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
