/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 1/5/2022
 * Hora: 23:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Proxys.
	/// </summary>
	public class AlumnoProxy:Persona,IAlumno
	//Proxy.Paso 1 ,creamos el proxy,que implementa la misma interface(IAlumno) que el sujeto real(Alumno)
	{
		protected IAlumno alumnoReal=null; //Paso 2 . Composicion con el objeto real
		protected int legajo,promedio,calificacion;
		public static int vecesCreada=0;//Para cambiar a estudios "solo"
		protected CompararAlumnos estrategia,estrategia2;
		
		private int queCrear=0;
		/*3 Alumno
		 * 5 Alumno Muy estudioso
		 * 6 Alumno decorado
		 * 7 Alumno estudioso decorado
		 * Modificar esto cuando haga falta
		 * Actualmente en la fabriaca esta en 6 y cuando sse crean 20 se cambia a 7
		 * */
		
		public AlumnoProxy(string n,int d,int l,int p,int qc):base(n,d){
			legajo=l;
			promedio=p;
			estrategia= new PorCalificacion(); 
			estrategia2=new PorDni();
			queCrear=qc;
		
		}
		
		//Comportamiento basico q sabe esolver
		public int getLegajo(){
			return legajo;
		}
		public void setLegajo(int l){
			legajo=l;
			if(alumnoReal ==null)
			{
				alumnoReal = new Alumno(nombre,dni,legajo,promedio);
				Console.WriteLine("Se creo Alumno real");
			}
			alumnoReal.setLegajo(l);
		
		}
		public int getDni(){
			return dni;
		}
		public void setDni(int d){
			dni=d;
			if(alumnoReal ==null)
			{
				alumnoReal = new Alumno(nombre,dni,legajo,promedio);
				Console.WriteLine("Se creo Alumno real");
			}
			alumnoReal.setDni(d);
		}
		
		public int getPromedio(){
			return promedio;
		}
		public void setPromedio(int o){
			promedio=o;
			if(alumnoReal ==null)
			{
				alumnoReal = new Alumno(nombre,dni,legajo,promedio);
				Console.WriteLine("Se creo Alumno real");
			}
			alumnoReal.setPromedio(o);
		}
		public string getNombre(){
			return nombre;
		}
		
		public void setNombre(string n){
			this.nombre=n;
		}
		public int getCalificacion(){
			return calificacion;
			
		}
		public void setCalificacion(int c){
			calificacion=c;
			if(alumnoReal ==null)
			{
				alumnoReal = new Alumno(nombre,dni,legajo,promedio);
				Console.WriteLine("Se creo Alumno real");
			}
			alumnoReal.setCalificacion(c);
		}
		
		public void setQueCrear(int n){
	
			queCrear=n;
		}
		public void cambiarEstrategia(CompararAlumnos a){
			estrategia=a;
		}
		
		
		//Todo esto no lo se hacer
		override public bool sosIgual(Comparable x){
			//Si sabemos el orden de los metodos no haria falta,como en etste caso		
			if(alumnoReal ==null)
			{
				alumnoReal = ((IAlumno)FabricaDeComparables.crearAleatorio(queCrear));
				alumnoReal.setCalificacion(calificacion);
				alumnoReal.setDni(dni);
				alumnoReal.setLegajo(legajo);
				alumnoReal.setNombre(nombre);
				alumnoReal.setPromedio(promedio);
//				
				Console.WriteLine("Se creo Alumno real");
			}

			
			return alumnoReal.sosIgual(x);//Delegamos la  peticion
		}
		override public bool sosMenor(Comparable x){
			if(alumnoReal ==null)
			{
				alumnoReal = ((IAlumno)FabricaDeComparables.crearAleatorio(queCrear));
				alumnoReal.setCalificacion(calificacion);
				alumnoReal.setDni(dni);
				alumnoReal.setLegajo(legajo);
				alumnoReal.setNombre(nombre);
				alumnoReal.setPromedio(promedio);
//				
				Console.WriteLine("Se creo Alumno real");
			}
				
			
			return alumnoReal.sosMenor(x);
		}
		override public bool sosMayor(Comparable x){
			if(alumnoReal ==null){
				alumnoReal = ((IAlumno)FabricaDeComparables.crearAleatorio(queCrear));
				alumnoReal.setCalificacion(calificacion);
				alumnoReal.setDni(dni);
				alumnoReal.setLegajo(legajo);
				alumnoReal.setNombre(nombre);
				alumnoReal.setPromedio(promedio);
//				
				Console.WriteLine("Se creo Alumno real");
			}
				
			
			return alumnoReal.sosMayor(x);
		}
		
		
		//Metodo complicado,el proxy necesita crear al objeto real
		virtual public int responderPregunta(int pregunta){
			if(alumnoReal ==null){
				//alumnoReal = new Alumno(nombre,dni,legajo,promedio);
				if(vecesCreada%2==0)
					queCrear=5;
				else{
					queCrear=3;
				}
				
				alumnoReal = ((IAlumno)FabricaDeComparables.crearAleatorio(queCrear));
				vecesCreada++;
				alumnoReal.setCalificacion(calificacion);
				alumnoReal.setDni(dni);
				alumnoReal.setLegajo(legajo);
				alumnoReal.setNombre(nombre);
				alumnoReal.setPromedio(promedio);
//				
				Console.WriteLine("Se creo Alumno real");
			}
			
			
				return alumnoReal.responderPregunta(pregunta);
		}
	
		public string mostrarCalificacion(){
			if(alumnoReal ==null)
			return ("Nombre: "+this.getNombre()+"  "+"| Calificacion: "+this.getCalificacion().ToString() );
			return alumnoReal.mostrarCalificacion();
		}
		
		override public string ToString(){
			return ("Nombre: "+this.getNombre()+"| Dni: "+this.getDni().ToString()+"| Legajo: "+this.getLegajo().ToString()+"| Promedio: "+this.getPromedio().ToString() );
		}
	}
	
/*	public class AlumnoMuyEstudiosoProxy:AlumnoProxy{
		
		public AlumnoMuyEstudiosoProxy(string n,int d,int l,int p):base(n,d,l,p)
		{
			//Hacer alumnos con fabricas y esta clase no hace falta
		}
		
		public override int responderPregunta(int pregunta)
		{
				if(alumnoReal ==null){
				alumnoReal = new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
				Console.WriteLine("Se creo Alumno real");
			}
			
			
				return alumnoReal.responderPregunta(pregunta);
			
		}
		
		public int getCalificacion(){
			return calificacion;
			
		}
	}
	
*/	
	
	public class ColaProxy:Coleccionable,IObservador{
		Cola colaReal;
		Comparable min =null;
		Comparable max = null;
		
		
		
		
		
		public void agregarObservador(){
			if(colaReal==null){
				colaReal=new Cola();
			}
			colaReal.agregarObservador(this);
		}
		
		
		public void actualizar(IObservado o){
			this.actualizarMinYMax();
		}
		
		
		public int cuantos(){
			
			if(colaReal==null)
				return 0;
		
			return colaReal.cuantos();
		}
		public bool contiene( Comparable c){
			if(colaReal==null)
				return false;
			return colaReal.contiene(c);
		}
		
		
		
		public Comparable minimo(){
			
			
			return min;
			
			
		}
		
		public void actualizarMinYMax(){
			min=colaReal.minimo();
			max=colaReal.maximo();
		}
		public Comparable maximo(){
			
			
			return max;
		}
		public void agregar(Comparable c){
			if(colaReal == null){
				colaReal = new Cola();
			}
			this.agregarObservador();
			colaReal.agregar(c);
		}
		public void ordenar(){
			
		}
		
		public IteradorDePaginas crearIterador(){
			if(colaReal == null){
				colaReal = new Cola();
			}
			return colaReal.crearIterador();
		}
		
		public void setOrdenInicio(OrdenEnAula1 or){
				if(colaReal == null){
				colaReal = new Cola();
			}
			colaReal.setOrdenInicio(or);
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 or){
			if(colaReal == null){
				colaReal = new Cola();
			}
			colaReal.setOrdenLlegaAlumno(or);
		}
		public void setOrdenAulaLlena(OrdenEnAula1 or){
			if(colaReal == null){
				colaReal = new Cola();
			}
			colaReal.setOrdenAulaLlena(or);
		}
		
		
	}
}
