﻿/*
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

			/*
			
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
//			
			*/
			//EJERCICIO 11 PRACTICA 2
			// Ninguna modificacion.Se podria agregar una estrategia para comparar por egreso si se quisiera
			
			
			
			
			
			
		
		//EJERCICIO 12 Y 13 Practica 2
			/*
//		Cola ca= new Cola();
//		llenarAlumnos(ca);
//		Console.WriteLine(ca.cuantos());
//		imprimirElementos(ca);
		//Funciona pero me veo "obligado" a crear un nuevo coleccionable (ColaAlumno) q este compuesto un coleccionable(Cola) para pasar como parametro ese coleccionable a IterarListaALlumno,para que este ultimo itere un coleccionable.
		// Si quisiera comparar con alumnos que esten almacenados en otro coleccionable,tendria que crear otro coleccionable mas por ejemplo PilaAlumno,que este compuesto por Pila
		//IterarLstaAlumno tiene que recibir siempre un coleccionable para poder iterarlo de forma generica
		//Otra forma es que reciba siempre una lista generica. No hace falta que se cree otro coleccionable.
			
			*/
			
			
			//*************************     P R A C T I C A   N 3    ************************************************************************************************
		
			//Ejercicio 6
			/*
			Console.WriteLine("Practica 3 | Ejercicio 6: ");
			
			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple m = new ColeccionMultiple(p,c);
			llenar(p,3);
			llenar(c,3);
			
			Console.WriteLine( "Metodo Informar");
			informar(m,3);
			
			*/
			//Ejercicio 7 
			/*
			Console.WriteLine("Practica 3 | Ejercicio 7: ");
		
			Coleccionable col=elegirColeccionable();
			
			llenar(col,3);
			Console.WriteLine( "Metodo Informar");
			informar(col,3);
			*/
			
			//Ejercicio 9
			/*
			Console.WriteLine("Practica 3 | Ejercicio 9: ");
			
			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple m = new ColeccionMultiple(p,c);
			llenar(p,4);
			llenar(c,4);
			
			Console.WriteLine( "Metodo Informar");
			informar(m,4);
			*/
			
			
			//Ejercicio 14
			/*		
			Console.WriteLine("Practica 3 | Ejercicio 14: ");
			
			Pila p = new Pila();
			llenar(p,4);
			Gerente g= new Gerente("Federico Yanequine",39876165);
			agregarObservador(p,g);
			jornadaDeVentas(p);
			informar(p,4);
			Console.WriteLine("Los Mejores vendedores fueron: \n");
			g.cerrar();
		
			*/
			//Ejercicio 15
			/*
			Console.WriteLine("Practica 3 | Ejercicio 15: ");
			
			Pila p = new Pila();
			VendedorPauperrimo vp= new VendedorPauperrimo("Vendedor malo",20145873,40000);
			p.agregar(vp);
			llenar(p,4);
			Gerente g= new Gerente("Federico Yanequine",39876165);
			Seguridad s = new Seguridad("Seguridad",11111111);
			Cliente c = new Cliente("cliente",11112311);
			Encargado e = new Encargado("Encargado",112313111);
			agregarObservador(p,g);
			agregarObservadorAPauperrimo(vp,s,c,e);
			jornadaDeVentas(p);
			informar(p,4);
			Console.WriteLine("Los Mejores vendedores fueron: \n");
			g.cerrar();
			*/
			
			
			
			//*************************     P R A C T I C A   N 4    ************************************************************************************************
		
			//Ejercicio 4
			/*
			Console.WriteLine("Practica 4 | Ejercicio 4: ");
			Teacher t= new Teacher();
			agregarStudents(t);
			t.teachingAClass();
		
			
			*/
	

	//Ejercicio 8
	/*
	Console.WriteLine("Practica 4 | Ejercicio 8: ");
	Teacher t= new Teacher();
	agregarStudents(t);
	t.teachingAClass();*/
			
	//Ejercicio 9
	/*
	Console.WriteLine("Practica 4 | Ejercicio 9: ");
	Coleccionable c =elegirColeccionable();
	Teacher t1 = new Teacher();
	t1.setStudents( new IterableAdapter(c));
	agregarStudents(t1);
	t1.teachingAClass();*/
	
//*************************     P R A C T I C A   N 5   ************************************************************************************************



	//Ejercio 2
	/*
	Console.WriteLine("Practica 5 | Ejercicio 2: ");
	Teacher t1= new Teacher();
	agregarStudents(t1);
	t1.teachingAClass();
	*/
	//Ejercicio 10
	/*
	Console.WriteLine("Practica 5 | Ejercicio 10: ");
		
	Coleccionable c =elegirColeccionable();
	
	
	
	Aula aula = new Aula();
	c.setOrdenInicio(new OrdenInicio(aula));
	c.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
	c.setOrdenAulaLlena(  new OrdenAulaLlena(aula));
	//Se crea Proxys de Alumnos
	llenar(c,8);
	llenar(c,8);
*/
	
	
	//Ejercicio 12
	/*
	Coleccionable cola = new ColaProxy();
	Console.WriteLine(cola.cuantos());
	Console.WriteLine(cola.minimo());
	Console.WriteLine(cola.maximo());
	
	cola.agregar(new Numero (5));
	cola.agregar(new Numero (3));
	cola.agregar(new Numero (8));
	Console.WriteLine(cola.cuantos());
	Console.WriteLine(cola.minimo());
	Console.WriteLine(cola.maximo());
	
	
	Console.WriteLine(cola.cuantos());
	Console.WriteLine(cola.minimo());
	Console.WriteLine(cola.maximo());
	Numero n= new Numero(15);
	cola.agregar(n);
	Console.WriteLine(cola.minimo());
	Console.WriteLine(cola.maximo());
	n.setValor(1);
	Console.WriteLine(cola.minimo());
	Console.WriteLine(cola.maximo());
		*/
	//*************************     P R A C T I C A   N 6   ************************************************************************************************
	

	//ejercio 2
	
// Con composicion	Adapter->Compuesto->proxy -> Alumno
/*
	Console.WriteLine("Practica 6 | Ejercicio 2: (Adapter->Compuesto->proxy -> Alumno)");
	Teacher t1= new Teacher();
	AlumnoCompuesto a= new AlumnoCompuesto();
	//PROXY 
	IAlumno comp1 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp2 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp3 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp4 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp5 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	a.agregarHijo(comp1);
	a.agregarHijo(comp2);
	a.agregarHijo(comp3);
	a.agregarHijo(comp4);
	a.agregarHijo(comp5);
	AlumnoAdapter aa= new AlumnoAdapter(a);
	t1.goToClass(aa);
		
	t1.teachingAClass();
	
	
*/
	// con composicion
	//	AlumnoAdapter ->Decoradores ->Compuesto -> Proxy ->  Alumno
	/*
	Console.WriteLine(" ");
	Console.WriteLine("Practica 6 | Ejercicio 2: (AlumnoAdapter ->Decoradores ->Compuesto -> Proxy ->  Alumno)");
	Teacher t2= new Teacher();
	AlumnoCompuesto aC= new AlumnoCompuesto();
	//PROXY 
	IAlumno comp11 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp22 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp33 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp44 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp55 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	aC.agregarHijo(comp11);
	aC.agregarHijo(comp22);
	aC.agregarHijo(comp33);
	aC.agregarHijo(comp44);
	aC.agregarHijo(comp55);
	IAlumno decorador= new DecoradorLegajo(aC);
	IAlumno decorador2= new DecoradorLetras(decorador);
	IAlumno decorador3= new DecoradorPromocion(decorador2);
	IAlumno decorador4= new DecoradorListado(decorador3);
	IAlumno decorador5= new DecoradorAsterisco(decorador4);
	
	AlumnoCompuestoAdapter aaa= new AlumnoCompuestoAdapter( ( (IAlumno)decorador5) );
	t2.goToClass(aaa);
		
	t2.teachingAClass();
	*/
	
//	Esto se podria hacer en fabrica de Compuestos,pero por el momento se dejo de esta manera para que sea mas general
	
/*	

		Console.WriteLine("Practica 6 | Ejercicio 4 y 5  ");
		
		Console.WriteLine("El jugador que saque el 1 de oro perdera");
		Console.WriteLine(" ");
		
		Persona p1=new Persona("Lautaro",1);
		Persona p2 = new Persona("Federico",2);
		
		JuegoDeCartas jg= new Sacar1deOro(p1,p2);
		
		Console.WriteLine("EL GANADOR ES: "+jg.jugar(p1,p2).getNombre);
		Console.WriteLine(" ");
		
		Console.WriteLine("******************************************************************************************* ");
		
		Console.WriteLine("Practica 6 | Ejercicio 6  ");
		Console.WriteLine("El jugador que tenga la carta mas alta,sumara puntos.Al llegar a los 3 ganara la partida");
		JuegoDeCartas may= new Mayor(p1,p2);
		
	
		
		Console.WriteLine("EL GANADOR ES : "+may.jugar(p1,p2).getNombre);
		
		
		
		
		//Si quiero que el juego se gane por puntos tengo q modificiar el metodo chequear ganador y a la sumo la clase del juego de cartas.
		//Si se quiere agregar mas personas habria que modificar la plantilla.
		
	*/
	
//	Ejercicio 8
		/*
	Console.WriteLine(" ");
	Console.WriteLine("Practica 6 | Ejercicio 8: ");
	Console.WriteLine("TORNEO DE SACAR 1 DE ORO");
	Console.WriteLine(" ");
	Persona persona1 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona2 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona3 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona4 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona5 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona6 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona7 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona8 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona9 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona10 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona11 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona12 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona13 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona14 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona15 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	Persona persona16 =( (Persona)FabricaDeComparables.crearAleatorio(2));
	
	
	ITorneo final = new Encuentro();
	ITorneo semi1 = new Encuentro();
	ITorneo semi2 = new Encuentro();
	ITorneo cuartos1 = new Encuentro();
	ITorneo cuartos2 = new Encuentro();
	ITorneo cuartos3 = new Encuentro();
	ITorneo cuartos4 = new Encuentro();

	((Encuentro)final).agregarHijo(semi1);
	((Encuentro)final).agregarHijo(semi2);
	 
	((Encuentro)semi1).agregarHijo(cuartos1);
	((Encuentro)semi1).agregarHijo(cuartos2);
	((Encuentro)semi2).agregarHijo(cuartos3);
	((Encuentro)semi2).agregarHijo(cuartos4);
	
	((Encuentro)cuartos1).agregarHijo(new Sacar1deOro(persona1,persona2));
	((Encuentro)cuartos1).agregarHijo(new Sacar1deOro(persona3,persona4));
	
	
	((Encuentro)cuartos2).agregarHijo(new Sacar1deOro(persona5,persona6));
	((Encuentro)cuartos2).agregarHijo(new Sacar1deOro(persona7,persona8));
	
	((Encuentro)cuartos3).agregarHijo(new Sacar1deOro(persona9,persona10));
	((Encuentro)cuartos3).agregarHijo(new Sacar1deOro(persona11,persona12));
	
	((Encuentro)cuartos4).agregarHijo(new Sacar1deOro(persona13,persona14));
	((Encuentro)cuartos4).agregarHijo(new Sacar1deOro(persona15,persona16));
	
	
	
	
	Console.WriteLine( "Ganador del toreno: " + final.jugar().getNombre);

	*/
	
	
	//*************************     P R A C T I C A   N 7   ************************************************************************************************	

	
	Console.WriteLine("Practica 7 | Ejercicio 3: (Adapter->Compuesto->proxy -> Alumno)");
	Teacher t1= new Teacher();

	//PROXY 
	
	//cinco Alumno generando datos aleatoriamente
	IAlumno comp1 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp2 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp3 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp4 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp5 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	Student student1= new AlumnoAdapter( ((IAlumno) comp1)  );
	Student student2= new AlumnoAdapter( ((IAlumno) comp2)  );
	Student student3= new AlumnoAdapter( ((IAlumno) comp3)  );
	Student student4= new AlumnoAdapter( ((IAlumno) comp4)  );
	Student student5= new AlumnoAdapter( ((IAlumno) comp5)  );
	
	//ADAPTER-PROXY-decoraod.ALUMNO
	
	//Muy estudisio por el proxy
	IAlumno comp6 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	IAlumno comp7 =( (IAlumno)FabricaDeComparables.crearAleatorio(8));
	Student student6= new AlumnoAdapter( ((IAlumno) comp6)  );
	Student student7= new AlumnoAdapter( ((IAlumno) comp7)  );
	
	
	AlumnoCompuesto aC= new AlumnoCompuesto();
	IAlumno comp11 =( (IAlumno)FabricaDeComparables.crearAleatorioDesdeArchivo(8));
	IAlumno comp22 =( (IAlumno)FabricaDeComparables.crearAleatorioDesdeArchivo(8));
	IAlumno comp33 =( (IAlumno)FabricaDeComparables.crearAleatorioDesdeArchivo(8));
	IAlumno comp44 =( (IAlumno)FabricaDeComparables.crearAleatorioDesdeArchivo(8));
	IAlumno comp55 =( (IAlumno)FabricaDeComparables.crearAleatorioDesdeArchivo(8));
	aC.agregarHijo(comp11);
	aC.agregarHijo(comp22);
	aC.agregarHijo(comp33);
	aC.agregarHijo(comp44);
	aC.agregarHijo(comp55);
	IAlumno decorador= new DecoradorLegajo(aC);
	IAlumno decorador2= new DecoradorLetras(decorador);
	IAlumno decorador3= new DecoradorPromocion(decorador2);
	IAlumno decorador4= new DecoradorListado(decorador3);
	IAlumno decorador5= new DecoradorAsterisco(decorador4);
	
		//ADAPTER-decorado-compuesto-PROXY-ALUMNO
	AlumnoAdapter aaa= new AlumnoAdapter( ( (IAlumno)decorador5) );

		
	

	t1.goToClass(student1);
	t1.goToClass(student2);
	t1.goToClass(student3);
	t1.goToClass(student4);
	t1.goToClass(student5);
	t1.goToClass(student6);
	t1.goToClass(student7);
						
	t1.goToClass(aaa);
		
	t1.teachingAClass();
	
	
	
	

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
				//Ejercicio 5
		private static void llenar(Coleccionable c,int queOpcion){
				for(int i=0; i <20;i++)
				{
					Comparable comp= FabricaDeComparables.crearAleatorio(queOpcion);
					c.agregar(comp);
				}
					
			
				}
		
		
		//Ejercicio 6
		private static void informar( Coleccionable c,int opcionElegida){
			Random random = new Random();
			Console.Write("Cuantos: ");
			Console.WriteLine(c.cuantos());
			Console.Write("Minimo: ");
			Console.WriteLine(c.minimo());
			Console.Write("Maximo: ");
			Console.WriteLine(c.maximo());
			
			Console.WriteLine("Para ver si esta ");
			Comparable comp;
			comp = FabricaDeComparables.crearPorTeclado(opcionElegida);
			
//			Alumno a = new Alumno("Lautaro Yanequine",43901862,5536,7);
//		Comparable c2 = new Numero(random.Next(1,100));  // A futuro modiifciar,en caso de ver si contiene otra clase habria que generar multiples informar
			if(c.contiene(comp))
				Console.WriteLine("Esta");
			else
				Console.WriteLine("No esta");
		}
		
		
		//Ejercicio 7 Practica 3
		private static Coleccionable elegirColeccionable(){
			int opcion ;
			Console.WriteLine("******************************************************************************\n" +
			                  "* Elije el coleccionable que desea crear        \n" +
			                  "* Opcion 1 : Pila\n" +
			                  "* Opcion 2 : Cola\n" +
			                  "* Opcion 3 : Coleccion Multiple\n" + 
			                  "* Opcion 4 : Conjunto\n"+
			                  "* Opcion 5 : Diccionario\n");
			
			opcion=int.Parse(Console.ReadLine());
			Coleccionable coleccionable= FabricaDeColeccionables.crearColeccionable(opcion);
			return coleccionable;
		}
		
		//EJERCICIO 7 . PRACTICA 2
		
		public static void imprimirElementos(Coleccionable c){
			
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
			llenar(cola,3);
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
		
		private static void jornadaDeVentas(Coleccionable c)
		{
			Random r = new Random();
			double monto;

			for(int i=0;i<20;i++){ //Para que cada vendedor etenga 20 ventas
				IteradorDePaginas ite = c.crearIterador();
				while(!ite.fin())  //hasta que no se llegue al final de la coleccion
					{
						monto=r.Next(1,7000);
						  //Proceso
						((Vendedor)ite.actual()).venta(monto);
						ite.siguiente();//Avanzo al proximo elemento-itero.
					}
			}
			
		
		
			
		}
		private static void agregarObservador( Coleccionable c ,IObservador g)
		{
			IteradorDePaginas ite = c.crearIterador();
			
			while(!ite.fin())  //hasta que no se llegue al final de la coleccion
			{
				
				  //Proceso
				  ((Vendedor)ite.actual()).agregarObservador(g);
				  ite.siguiente();//Avanzo al proximo elemento-itero.
				  }

			}
		private static void agregarObservadorAPauperrimo( VendedorPauperrimo c ,IObservador se,IObservador cli,IObservador enc)
		{
			c.agregarObservador(se);
		    c.agregarObservador(cli);
			c.agregarObservador(enc);

		}
		
		private static void  agregarStudents(Teacher t){
			for(int i = 0; i<20;i++)
			{
				if(i<11){
					//Crea alumn
					
					Comparable comp= FabricaDeComparables.crearAleatorio(8);
					/*
					IAlumno decorador= new DecoradorLegajo( ((IAlumno)comp) );
					IAlumno decorador2= new DecoradorLetras( decorador );
					IAlumno decorador3= new DecoradorPromocion( decorador2 );
					IAlumno decorador4= new DecoradorListado( decorador3 );
					IAlumno decorador5= new DecoradorAsterisco(decorador4 );
					*/
					
					Student student= new AlumnoAdapter( ((IAlumno) comp)  );
					t.goToClass(student);
				}else{
					
					Comparable comp= FabricaDeComparables.crearAleatorio(8);
					((AlumnoProxy)comp).setQueCrear(5);/*
					IAlumno decorador= new DecoradorLegajo( ((IAlumno)comp) );
					IAlumno decorador2= new DecoradorLetras( decorador );
					IAlumno decorador3= new DecoradorPromocion( decorador2 );
					IAlumno decorador4= new DecoradorListado( decorador3 );
					IAlumno decorador5= new DecoradorAsterisco(decorador4 );
					Student student2= new AlumnoAdapter( decorador5 );
					//Por el momento solo con aleatorio(completo)*/

					Student s2 = new AlumnoAdapter(((IAlumno) comp)  );
					t.goToClass(s2);
				}
			}
		}
		
		}
	}
