/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 6/4/2022
 * Hora: 10:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	//Ejercicio 2
	
	
	//Ejercicio 4
	
	//Paso 4 : Hcaer que los agregados implementen Iterable
	public class Cola  : Coleccionable,iterable
	{

		
		private List<Comparable> datos;
		public Cola(){
			datos=new List<Comparable>();
		}
		
		public List<Comparable> Datos{
			get{ return datos;}
		}
		public void encolar(Comparable elem) {
			this.datos.Add(elem);
		}
	
		public Comparable desencolar() {
			Comparable temp = this.datos[0];
			datos.RemoveAt(0);
			return temp;
		}
		
		public Comparable tope() {
			return this.datos[0]; 
		}
		
		public bool esVacia() {
				return this.datos.Count == 0;
			}
		public int cuantos(){
			return datos.Count;
		}
		public bool contiene (Comparable c){
			for(int i = 0; i<this.cuantos(); i++){
				if(datos[i].sosIgual(c))
					return true;
			}
			return false;
		}
		public void agregar( Comparable c){
			encolar(c);
		}
		
		public Comparable minimo(){
			Comparable min=datos[0];
			foreach(Comparable elemento in datos){
				if(elemento.sosMenor(min))
				{
					min=elemento;
				}
			}
			return min;
		}
		
		public Comparable maximo(){
			Comparable max=datos[0];
			foreach(Comparable elemento in datos){
				if(!elemento.sosMenor(max))
				{
					max=elemento;
				}
			}
			return max;
		}
		
		//El coleccionable es el responsable de ejecutar el iterador correcto.
		public IteradorDePaginas crearIterador(){
			return new IterarListaAlumno(datos);
		}
		
		
	}
	//Por si se requiere forma que reciba un coleccionable IterarAlumno
	/*
//	public class ColaAlumno  : Coleccionable,iterable
//	{
//
//		
//		private Cola datos;
//		public ColaAlumno(){
//			datos=new Cola();
//		}
//		
//		public Cola Datos{
//			get{ return datos;}
//		}
//		public void encolar(Comparable elem) {
//			this.datos.agregar(elem);
//		}
//	
//		public Comparable desencolar() {
//			return datos.desencolar();
//		}
//		
//		public Comparable tope() {
//			return datos.tope();
//		}
//		
//		public bool esVacia() {
//			return datos.esVacia();
//			}
//		public int cuantos(){
//			return datos.cuantos();
//		}
//		public bool contiene (Comparable c){
//			return datos.contiene(c);
//		}
//		public void agregar( Comparable c){
//			datos.agregar(c);
//		}
//		
//		public Comparable minimo(){
//			return datos.minimo();
//		}
//		
//		public Comparable maximo(){
//			return datos.maximo();
//		}
//		
//		//El coleccionable es el responsable de ejecutar el iterador correcto.
//		public IteradorDePaginas crearIterador(){
//			return new IterarListaAlumno(datos);
//		}
//		
//		
//	}
	*/
	public class Pila : Coleccionable,iterable{
		private List<Comparable> datos;
		public Pila(){
			datos= new List<Comparable>();
		}
		
		public void apilar(Comparable elem)   
		{
			datos.Add(elem);
		}
		public Comparable desapilar()
		{
//			Comparable aux;
//			int tam=datos.Count;
//			aux=datos[tam-1];
//			datos.Remove(aux);
//			return aux;
			
			Comparable aux= datos[datos.Count-1];
			datos.RemoveAt(datos.Count- 1);
			return aux;
		}
		public bool vacia()
		{
			return datos.Count==0;
		}
		public Comparable tope()
		{
			int tam=datos.Count;
			return datos[tam-1];
		}
		public int cuantos(){
			return datos.Count;
		}
		public bool contiene (Comparable c){
//			return datos.Contains(c);   MAL
			
			for(int i = 0; i<this.cuantos(); i++){
				if(datos[i].sosIgual(c))
					return true;
			}
			return false;
		}
		public void agregar( Comparable c){
			apilar(c);
		}
		public Comparable minimo(){
//			Comparable min=datos[0];
//			foreach(Comparable elemento in datos){
//				if(elemento.sosMenor(min))
//				{
//					min=elemento;
//				}
//			}
//			return min;
			
			Comparable masChico = datos[0];
			for(int i =1 ; i<this.cuantos();i++)
			{
				if(datos[i].sosMenor(masChico))
					masChico=datos[i];
			}
			return masChico;
		}
		public Comparable maximo(){
			Comparable max=datos[0];
			foreach(Comparable elemento in datos){
				if(!elemento.sosMenor(max))
				{
					max=elemento;
				}
			}
			return max;
		}		
		
		//El coleccionable es el responsable de ejecutar el iterador correcto.
		public IteradorDePaginas crearIterador(){
			return new IterarLista(datos);
		}
		
			
	}
	
	public class ColeccionMultiple : Coleccionable,iterable
	{
		Random r= new Random();
		Pila pila;
		Cola cola;
		
		public ColeccionMultiple(Pila p,Cola c){
			pila=p;
			cola=c;
		}
		
		public int cuantos(){
			return pila.cuantos()+cola.cuantos();
		}
		
		public Comparable minimo(){
			if(pila.minimo().sosMenor(cola.minimo())){
				return pila.minimo();
			}
			
			return cola.minimo();

		}
		
		public Comparable maximo(){
			if(pila.maximo().sosMayor(cola.maximo())){
				return pila.maximo();
			}
			
			return cola.maximo();

		}
		public void agregar(Comparable c){
			int num=r.Next(2);
			//Guarda de manera aleatoria
			if(num ==0)
				pila.agregar(c);
			else 
				cola.agregar(c);
			return;
		}
		
		public bool contiene(Comparable c){
			bool aux=false;
			if(pila.contiene(c) || cola.contiene(c))
				aux=true;
			return aux;
		}
		public IteradorDePaginas crearIterador(){
			return new IterarColeccionMultiple(pila,cola);
		}
		
	}
	
	public class Conjunto : Coleccionable,iterable{
		
		//Almacena metodos sin repeticion
		
		private List<Comparable> datos;
		public Conjunto(){
			datos= new List<Comparable>();
		}
		
		public void agregar(Comparable x){
			//agrega el elemento al conjunto si es que éste no existe
			if(!contiene(x))
				datos.Add(x);
			
		}
		
//		public bool pertenece(Comparable x){
//			return datos.Contains(x);
//		}

		public int cuantos(){
			return datos.Count;
		}
		public bool contiene (Comparable c){
//			return datos.Contains(c);   MAL
			
			for(int i = 0; i<this.cuantos(); i++){
				if(datos[i].sosIgual(c))
					return true;
			}
			return false;
		}
		public Comparable minimo(){
			Comparable min=datos[0];
			foreach(Comparable elemento in datos){
				if(elemento.sosMenor(min))
				{
					min=elemento;
				}
			}
			return min;
		}
		
		public Comparable maximo(){
			Comparable max=datos[0];
			foreach(Comparable elemento in datos){
				if(!elemento.sosMenor(max))
				{
					max=elemento;
				}
			}
			return max;
		}

		public List<Comparable> Datos{
			get{ return datos;}
		}
		
		//El coleccionable es el responsable de ejecutar el iterador correcto.
		public IteradorDePaginas crearIterador(){
			return new IterarLista(datos);
		}
	}
	

	public class Diccionario : Coleccionable,iterable{
		
		//Coleccion de elementos,donde cada elemento tiene una clave asociada.Las claves no pueden repetirse
		
		
		private Conjunto datos; // Almacena ClaveValor en un Conjunto
		private List<Comparable> valores; //Almacena solo los valores. Se va a iterar sobre esto
		private Random r = new Random();
		
		
		public Diccionario(){
			datos=new Conjunto();	
			valores= new List<Comparable>(); 
		}
		
		
		public bool comparacionClaves( ClaveValor cv1,ClaveValor cv2){
			return cv1.Clave.sosIgual(cv2.Clave);
		}
		
		public void agregar(Comparable ClaveParametro,Comparable ValorParametro)
		{

			ClaveValor cvNuevo= new ClaveValor(ClaveParametro,ValorParametro);
			bool aux=true;
			for(int i = 0; i<datos.cuantos();i++)
			{
				if(comparacionClaves(((ClaveValor)datos.Datos[i]),cvNuevo))
				   {
				   	((ClaveValor)datos.Datos[i]).Valor=ValorParametro;
				   	valores[i]=ValorParametro;
				  
				   	
				   	aux=false;
				   	break;
				   }
			}
			if(aux)
			{
				datos.agregar(cvNuevo);
				valores.Add(ValorParametro);
			
			}
			
		}
		public void agregar(Comparable valor){
		
			
			Numero n= new Numero(r.Next(3000));
		
			agregar(n,valor);
			

		}
			
		
		public Comparable valorDe(Comparable clave){

			for(int i = 0 ; i <datos.cuantos();i++)
			{
				ClaveValor aux1 = ((ClaveValor)datos.Datos[i]);
				if(aux1.Clave.sosIgual(clave))
				{
					
					return aux1.Valor;
		
				}
			}
				return null;
		}
		
		public int cuantos(){
			return datos.cuantos();
		}
		public bool contiene( Comparable valor){
			for(int i = 0 ; i <datos.cuantos();i++)
			{
				ClaveValor aux1 = ((ClaveValor)datos.Datos[i]);
				if(aux1.Valor.sosIgual(valor))
				{
					
					return true;
		
				}
			}
				return false;
		}
		
		public Comparable minimo(){
			//Compara solamente por valor 
			
			Comparable min= valores[0];
			for(int i = 1 ; i <valores.Count;i++)
			{
				Comparable aux1 = valores[i];
					if(aux1.sosMenor(min))
						min=aux1;
			}
			return min;
		}
		public Comparable maximo(){
			
			Comparable max= valores[0];
			for(int i = 1 ; i <valores.Count;i++)
			{
				Comparable aux1 = valores[i];
					if(aux1.sosMayor(max))
						max=aux1;
			}
			return max;
		
		}
		

		
		//El coleccionable es el responsable de ejecutar el iterador correcto.
		public IteradorDePaginas crearIterador(){
			return new IterarLista(valores);
		}
	}
	
	
	
	
	
	
	
	
		
}
