/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 19/4/2022
 * Hora: 11:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1
{
	/// <summary>
	/// Description of Iteradores.
	/// </summary>
//Paso 2 Implementar iterador concretos
	
	public class IterarLista:IteradorDePaginas{
		
		/*es el único objeto que conoce el estado interno del elemento a recorrer,en este caso Colecionables.Sabiendo esto implementa la forma de recorrer el coleccionble
		 en este caso una lista.*/
		
		int paginaActual;
		List<Comparable> lista;
		public IterarLista(List<Comparable> l)
		{
			lista=l;
			primero();
		}
		
		public void primero(){
			paginaActual=0;
		}
		public void siguiente(){
			paginaActual+=1;
		}
		public bool fin(){
			return paginaActual >=lista.Count;
		}
		public Comparable actual(){
			return lista[paginaActual];
		}
	}
	
	


	public class IterarColeccionMultiple:IteradorDePaginas{
		int paginaActual;
		Coleccionable p;
		Coleccionable	c;
		List<Comparable> auxiliar= new List<Comparable>();
		public IterarColeccionMultiple(Coleccionable pi, Coleccionable co)
		{
			p=pi;
			c=co;
			//Recorro Colecionables de manera generica y voy agregando los elementos a una lista auxiliar para luego recorrer uno por uno
			
			
			IteradorDePaginas a= c.crearIterador();
			IteradorDePaginas b= p.crearIterador();
			while(!a.fin())  //hasta que no se llegue al final de la coleccion
			{
				auxiliar.Add(a.actual());  //Proceso
				a.siguiente();//Avanzo al proximo elemento-itero.
			}
			while(!b.fin())  //hasta que no se llegue al final de la coleccion
			{
				auxiliar.Add(b.actual());  //Proceso
				b.siguiente();//Avanzo al proximo elemento-itero.
			}
		}
		
		public void primero(){
			paginaActual=0;
		}
		public void siguiente(){
			paginaActual++;
		}
		public bool fin(){
			return paginaActual >=auxiliar.Count;
		}
		public Comparable actual(){
			return auxiliar[paginaActual];
		}
	}
	


	public class IterarListaAlumno:IteradorDePaginas{
		int paginaActual;
		Alumno alumnoPromedio = new Alumno("Lautaro",22345678,111100,7);
		Coleccionable listaRecibia;
		Conjunto alumnosMayores;
		public IterarListaAlumno(Coleccionable l){
			listaRecibia=l;
			IteradorDePaginas a = listaRecibia.crearIterador();
			alumnosMayores = new Conjunto();
			
			
			while(!a.fin())  //hasta que no se llegue al final de la coleccion
			{
				if(!alumnoPromedio.sosMayor(a.actual()))
					alumnosMayores.agregar(a.actual());
				a.siguiente();//Avanzo al proximo elemento-itero.
				
			}
			
		}
		
		public void primero(){
			paginaActual=0;
		}
		public void siguiente(){
			paginaActual+=1;
		}
		public bool fin(){
			return paginaActual >=alumnosMayores.cuantos()-1;
		}
		public Comparable actual(){
			return alumnosMayores.Datos[paginaActual];
			
		}
	}

	

	//	public class IterarPila:IteradorDePaginas{
//		int paginaActual;
//		List<Comparable> lista;
//		public IterarPila(List<Comparable> l)
//		{
//			lista=l;
//			primero();
//		}
//		
//		public void primero(){
//			paginaActual=lista.Count-1;
//		}
//		public void siguiente(){
//			paginaActual-=1;
//		}
//		public bool fin(){
//			return paginaActual < 0;
//		}
//		public Comparable actual(){
//			return lista[paginaActual];
//		}
//	}
	
	
}
