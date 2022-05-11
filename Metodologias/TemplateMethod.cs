/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 7/5/2022
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1
{
	/// <summary>
	/// Description of TemplateMehotd.
	/// </summary>
	/// 

	abstract public class JuegoDeCartas:ITorneo{ //Paso 1
		
		int carta=0;  //Hay 50
		bool termino=false;
		Persona ganador= null;
		Persona jugador1 ,jugador2;
		
		protected static Random r = new Random();
		
		public JuegoDeCartas(Persona p1,Persona p2){
			jugador1=p1;
			jugador2=p2;
		}
		
		public Persona jugar(){
			return jugar(jugador1,jugador2);
		}
		
		public Persona jugar(Persona p1,Persona p2){
			while(ganador==null){
			this.mezclarMazo();
			this.repartoCartas();
			this.jugarUnaMano();
			ganador= this.chequearGanador(p1,p2);}
			return ganador;
		}
		
		
		protected void mezclarMazo(){
			Console.WriteLine("Mezclando el maso");
		}
		
		abstract protected void repartoCartas();
		
		protected void jugarUnaMano(){
				this.tomarCartas();
				this.descartarCartas();
		}
		//Los metodos tienen q ser privados
		abstract protected void tomarCartas();
		abstract protected void descartarCartas();
		abstract protected Persona chequearGanador(Persona p1,Persona P2);//Tiene q devolver bool
	}
	
	
	
	public class Sacar1deOro :JuegoDeCartas{
			int unoDeOro=32;
			int cartaP1,cartaP2;
			int puntos1=0,puntos2=0;
			
			
			public Sacar1deOro(Persona p1,Persona p2):base(p1,p2){
				
			}
			
			override protected void  repartoCartas(){
				Console.WriteLine("Repartiendo Carta");
			}
			
			override protected void tomarCartas(){
				Console.WriteLine("Tomando Cartas");
				cartaP1=r.Next(51);
				cartaP2=r.Next(51);
			}
			override protected void descartarCartas(){
				Console.WriteLine("descartando Cartas");
			}
			
		override protected  Persona chequearGanador(Persona p1,Persona p2)
		{
			if(cartaP1==unoDeOro)
			{
				
					Console.WriteLine(" **************************Ganador jugador DOS "+p2.getNombre+ " **************************");
					Console.WriteLine(" ");
					return p2;
			}
			else if( cartaP2==unoDeOro){
				Console.WriteLine("************************** Ganador jugador UNO "+p1.getNombre+" **************************" );
				Console.WriteLine(" ");
				return p1;
				
			}
			else
				Console.WriteLine("Aun no hay ganador");
		
			return null;
			
			
		}
			
	}
	
	public class Mayor :JuegoDeCartas{
		int puntosP1=0,puntosP2=0;
		int cartaP1,cartaP2;
		
		public Mayor(Persona p1,Persona p2):base(p1,p2){
			
		}
		
		override protected void  repartoCartas(){
				Console.WriteLine("Repartiendo Carta");
			}
			
		override protected void tomarCartas(){
				Console.WriteLine("Tomando Cartas");
				cartaP1=r.Next(51);
				cartaP2=r.Next(51);
			}
		override protected void descartarCartas(){
				Console.WriteLine("descartando Cartas");
			}
		
		override protected  Persona chequearGanador(Persona p1,Persona p2)
		{
			if(cartaP1>cartaP2)
			{
				Console.WriteLine("Jugador UNO gano un punto************");
				puntosP1++;
				if(puntosP1==3){
					Console.WriteLine("****************Ganador jugador UNO***************");
					Console.WriteLine(" ");
					return p1;}
			}
			else if( cartaP2>cartaP1){
				Console.WriteLine("Jugador DOS gano un punto********************");
				puntosP2++;
				if(puntosP2==3)
				{
					Console.WriteLine("******************Ganador Jugador DOS**********************");
					Console.WriteLine(" ");
					return p2;
				}
			}
			Console.WriteLine("Aun no hay ganador");
		
			return null;
			
			
		}
	}
	
	
	
//	16 jugadores que se enfrentan de a dos.La idea es simular un torneo
//	Un objeto que representa el toreno. Torneo.jugar()
//	Resolverlo con Composite,donde cada compuesto representa el partido entre dos jugadores
//	La hoja seria el template Method concreto,pero el composite tendria el compuesto entre dos jugadores
//	Los cruces forman un arbol,habria que ver como se elige el ganador
	
	public interface ITorneo{
		Persona jugar();
		Persona jugar(Persona p1,Persona p2);

	}

	
	public class Encuentro:ITorneo{
		List<ITorneo> hijos=new List<ITorneo>();
		
		Persona p1,p2;
		
		public void agregarHijo(ITorneo a){
			hijos.Add(a);
		}
		
		public Persona jugar(){
			Persona ganador1= hijos[0].jugar();
			Persona ganador2= hijos[1].jugar();
			Sacar1deOro a = new Sacar1deOro(ganador1,ganador2);
			return a.jugar(ganador1,ganador2);
		}
		
		public Persona jugar(Persona p1,Persona p2){
			
			Sacar1deOro a = new Sacar1deOro(p1,p2);
			return a.jugar(p1,p2);
		}
	}

	
}
