/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 5/4/2022
 * Hora: 19:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1

{


	class Program
	{
		//Ejercicio 5
		private static void llenar(Coleccionable c){
			Random random = new Random();
				for(int i=0; i <20;i++)
					c.agregar(new Numero(random.Next(1,100)));
			}
		
		private static void llenarPersonas(Coleccionable c){
			string[] nombres= { "juan", "pablo", "Paco", "jose", "Alberto"};
			String[] apellidos = { "sanchez", "perez", "lopez", "zelaya", "alvarez"};
			Random random = new Random();
				for(int i=0; i <20;i++)
					c.agregar(new Persona(nombres[random.Next(0,5)] + " " + apellidos[random.Next(0,5)],random.Next(0,44444444)));
			}	
		
		private static void llenarAlumnos(Coleccionable c){
			string[] nombres= { "juan", "pablo", "Julian", "jose", "Alberto","Lautaro","Pedro","Agustin","Jeremias","Martin"};
			String[] apellidos = { "sanchez", "perez", "lopez", "zelaya", "alvarez","Yanequine","Martinez"};
			Random random = new Random();
				for(int i=0; i <3;i++)
					c.agregar(new Alumno(nombres[random.Next(0,9)] + " " + apellidos[random.Next(0,6)],random.Next(0,44444444)
					                     ,random.Next(0,10000),random.Next(5,10)));
//				c.agregar(new Alumno("Lautaro Yanequine",43901862,5536,7)); Para ver si funciona el "Esta" de Informar
			}		
				
		
		//Ejercicio 6
		private static void informar( Coleccionable c){
			Random random = new Random();
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			Alumno a = new Alumno("Lautaro Yanequine",43901862,5536,7);
//			Comparable c2 = new Numero(random.Next(1,100));  // A futuro modiifciar,en caso de ver si contiene otra clase habria que generar multiples informar
			if(c.contiene(a))
				Console.WriteLine("Esta");
			else
				Console.WriteLine("No esta");
		}
		
		//EJERCICIO 7 . PRACTICA 2
		
		private static void imprimirElementos(Coleccionable c){
			
			/* Este metodo va a funcionar independientemente del coleccionable que se le pase por parametro
			 gracias al patron Iterator cada coleccionable sabe como iterar sus elementos*/
			IteradorDePaginas ite = c.crearIterador();
			
			while(!ite.fin())  //hasta que no se llegue al final de la coleccion
			{
				Console.WriteLine(ite.actual());  //Proceso
				ite.siguiente();//Avanzo al proximo elemento-itero.
			}
		}
		
		//EJERCICIO 9 Practica 2
		private static void cambiarEstrategia(Coleccionable c, CompararAlumnos a ){
		IteradorDePaginas ite = c.crearIterador();
		while(!ite.fin())  //hasta que no se llegue al final de la coleccion
			{
			((Alumno)ite.actual()).cambiarEstrategia(a);  //Proceso
				ite.siguiente();//Avanzo al proximo elemento-itero.
			}
		
		}
		
		
		private static void multiplesIteradores()

		{
			Cola cola = new Cola();
			llenarAlumnos(cola);
			Random r = new Random();
			
			IteradorDePaginas[] iteradores = new IterarLista[3];
			bool [] fin = new bool[3];
			
			for(int i = 0;i<3;i++){
				iteradores[i] = cola.crearIterador();
				fin[i] = false;
			}
			while((!fin[0]) ||	(!fin[1]) || (!fin[2])){
			
//				for(int ite = 0;ite<3;ite++){
			
			
				int ite= r.Next(3);
				
						if(!iteradores[ite].fin())
				{
					Console.WriteLine(iteradores[ite].actual());
					iteradores[ite].siguiente();
				}
				else
					fin[ite]=true;
				}
			
//			}
			//Podriamos haberlo hecho sin iteradores,pero habria que implementar el recorrido de la cola o de cualquier coleccionable que utilizaramos.
		}
//			
		public static void Main(string[] args)
		{
			
			
			
			
			/* P R A C T I C A   N 1*/ 
			
			//Ejercicio 5
		
			
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			/*
			
			//Tratar de definir siempre tipo de datos interfaces en este caso comparable
//			Comparable c1,c2,c3;
//			c1= new Numero(4);
//			c2 = new Numero(8);
//			c3 = new Numero(4);
//			
//
//			Cola cola= new Cola();
//			cola.agregar(c1);
//			cola.encolar(c2);
//			Numero min= (Numero)cola.maximo();
//			Console.WriteLine(min.getValor);
			
			
			//Ejercicio 9
//			Pila p = new Pila();
//			Cola c= new Cola();
//			ColeccionMultiple cm= new ColeccionMultiple(p,c);
//			llenar(p);
//			llenar(c);
//			informar(c);
//			informar(p);
//			informar(cm);

		//Ejercio 10 . Nada,gracias a trabjar con las interfaces,todo lo creado es "nuevo"y no afecta a lo anteirior. La interfaces permite reutilizar el codigo de manera eficiente y tener un orden de los metodos			
			*/
			 
			
		//Ejercicio 13 y 14
		/*
			Pila pp = new Pila();
			Cola cp= new Cola();
			ColeccionMultiple cmp= new ColeccionMultiple(pp,cp);
			llenarPersonas(pp);
			llenarPersonas(cp);
			informar(cmp);
			
			//Ejercicio 14. Nada,solo el random del llenar personas para que llenene personas en vez de numeros
			*/
			
			//EJERCICIO 17,18,19 PRACTICA 1
			

			/*
			Pila pa = new Pila();
			Cola ca= new Cola();
			ColeccionMultiple cma= new ColeccionMultiple(pa,ca);
			llenarAlumnos(pa);
			llenarAlumnos(ca);
			informar(cma); 
			 
			 
			 //Funciono. No fue necesario gracias a la herencia de la clase Persona. El criterio de comparacion fue de comparar Dni ya que lo heredo de personas
			
			//Ejercicio 19
			//Se podria habaer hecho lo mismo pero con mucho codigo duplicado,"herencia obligadas",etc
		
			 
			 */
			
			
			
			
			
			
		/* P R A C T I C A    N 2 */
		
		
			//FUNCIONAMIENTO DE DICCIONARIO
			/*
			Diccionario dic = new Diccionario();
			Numero n1 =new Numero(1);
			Numero n11 =new Numero(12);
			Numero n2 =new Numero(14);
			Numero n22 =new Numero(78);
			Numero n3 = new Numero(100);
			Numero n4 = new Numero(140);
	
	
			dic.agregar(n3);
			dic.agregar(n4);
			dic.agregar(n1);
			dic.agregar(n3);
			dic.agregarAsociacion(n1,n2);
			dic.agregarAsociacion(n2,n3);
			Console.WriteLine(dic.contiene(n2));
			
			imprimirElementos(dic);
			
	
			Console.WriteLine(" Metodos");
			Console.WriteLine(dic.maximo());
			Console.WriteLine(dic.minimo());
			Console.WriteLine(dic.valorDe(n1)); 

			*/
			
			
			
		
			// EJERCICIO 8 . PRACTICA 2
		
			/*
			Pila pa = new Pila();
			Cola ca= new Cola();
			Conjunto conj= new Conjunto();
			Diccionario dic = new Diccionario();
			llenarAlumnos(pa);
			llenarAlumnos(ca);
			llenarAlumnos(conj);
			llenarAlumnos(dic); 
			

			
			Console.WriteLine("Imprimiendo desde Pila");
			Console.WriteLine(" ");
			imprimirElementos(pa);
			Console.WriteLine(" ");
			Console.WriteLine("Imprimiendo desde Cola ");
			Console.WriteLine(" ");
			imprimirElementos(ca);
			Console.WriteLine(" ");
			Console.WriteLine("Imprimiendo desde Conjunto");
			Console.WriteLine(" ");
			imprimirElementos(conj);
			Console.WriteLine(" ");
			Console.WriteLine(dic.cuantos());
			Console.WriteLine("Imprimiendo desde Diccionario");
			Console.WriteLine(" ");
			imprimirElementos(dic); 
		
*/
		
	
			//EJERCICIO 10 y 11PRACTICA 2

			
			
			Cola c= new Cola();
			CompararAlumnos Pornombre= new PorNombre();
			CompararAlumnos Pordni= new PorDni();
			CompararAlumnos Porpromedio= new PorPromedio();
			CompararAlumnos Porlegajo= new PorLegajo();
			llenarAlumnos(c);
			cambiarEstrategia(c,Pornombre );
			Console.WriteLine("Estrategia por Nombre");
			informar(c);
			Console.WriteLine(" ");
				
			Console.WriteLine("Estrategia por Dni");
			cambiarEstrategia(c,Pordni);
			informar(c);
			Console.WriteLine(" ");
			
						
			Console.WriteLine("Estrategia por Promedio");
			cambiarEstrategia(c,Porpromedio);
			informar(c);
			Console.WriteLine( " ");
			Console.WriteLine("Estrategia por Legajo");
			cambiarEstrategia(c,Porlegajo);
			informar(c);
			
			
			//EJERCICIO 11 PRACTICA 2
			// Ninguna modificacion.Se podria agregar una estrategia para comparar por egreso si se quisiera
			
			
			
			
			
			
		
		//EJERCICIO 12 Y 13 Practica 2
			/*
		ColaAlumno ca= new ColaAlumno();
		llenarAlumnos(ca);
		Console.WriteLine(ca.cuantos());
		imprimirElementos(ca);
		//Funciona pero me veo "obligado" a crear un nuevo coleccionable (ColaAlumno) q este compuesto un coleccionable(Cola) para pasar como parametro ese coleccionable a IterarListaALlumno,para que este ultimo itere un coleccionable.
		// Si quisiera comparar con alumnos que esten almacenados en otro coleccionable,tendria que crear otro coleccionable mas por ejemplo PilaAlumno,que este compuesto por Pila
		//IterarLstaAlumno tiene que recibir siempre un coleccionable para poder iterarlo de forma generica
			*/
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
			
		}
	}
}