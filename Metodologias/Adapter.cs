/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 28/4/2022
 * Hora: 21:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Semana1
{
	/// <summary>
	/// Description of Adapter.
	/// </summary>
	public class AlumnoAdapter:Student{//Subclase del objetivo. En este caso Student
		//Paso 1. 1 Tener una composicion al adaptable
		IAlumno alumno; //Adaptable.El adaptador tiene una instancia de la clase que se desea adaptar
		
		public AlumnoAdapter(IAlumno a){
			alumno=a;
		}
		public IAlumno Alumno{
			get{return alumno;}
		}
		
		//Paso 1.2 Hcaer la traduccion de todos los metodos de objetivo al
		//Correspondiente adaptable
		
		public string getName(){
			return alumno.getNombre();
		}
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		public string showResult(){
			return alumno.mostrarCalificacion();
		}
		public bool equals(Student student){
			return alumno.sosIgual(    ((Comparable)((AlumnoAdapter)student).Alumno)      );
			
			
		}
		public bool lessThan(Student student){
			return alumno.sosMenor(   ((Comparable)((AlumnoAdapter)student).Alumno)     );
		}
		public bool greaterThan(Student student){
			return alumno.sosMayor(   ((Comparable)((AlumnoAdapter)student).Alumno)     );
		}
	}
	
	public class AlumnoCompuestoAdapter:Student{//Subclase del objetivo. En este caso Student
		//Paso 1. 1 Tener una composicion al adaptable
		IAlumno alumno; //Adaptable.El adaptador tiene una instancia de la clase que se desea adaptar
		
		public AlumnoCompuestoAdapter(IAlumno a){
			alumno=a;
		}
		public IAlumno Alumno{
			get{return alumno;}
		}
		
		//Paso 1.2 Hcaer la traduccion de todos los metodos de objetivo al
		//Correspondiente adaptable
		
		public string getName(){
			return alumno.getNombre();
		}
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		public string showResult(){
			return alumno.mostrarCalificacion();
		}
		public bool equals(Student student){
			return alumno.sosIgual(    ((Comparable)((AlumnoAdapter)student).Alumno)      );
			
			
		}
		public bool lessThan(Student student){
			return alumno.sosMenor(   ((Comparable)((AlumnoAdapter)student).Alumno)     );
		}
		public bool greaterThan(Student student){
			return alumno.sosMayor(   ((Comparable)((AlumnoAdapter)student).Alumno)     );
		}
	}
	
			
	public class IterableAdapter:Collection{
		Coleccionable iterable;
		
		
		public IterableAdapter(Coleccionable a){
			iterable=a;
		}
	
		public IteratorOfStudent getIterator(){
			return new IteradorAdapter( iterable.crearIterador());
		}
		public void addStudent(Student student){
			
			iterable.agregar( (((AlumnoAdapter)student).Alumno)  );
				
		}
		public void sort(){
			iterable.ordenar();
		}
	}
	
	
	public class IteradorAdapter:IteratorOfStudent{
		
		IteradorDePaginas ite;
		
		public IteradorAdapter(IteradorDePaginas a){
			ite=a;
		}
		public IteradorDePaginas Iterador{
			get{return ite;}
		}
		
		public void beginning(){
			ite.primero();
		}
		public bool end(){
			return ite.fin();
		}
		public Student current(){
			return  new AlumnoAdapter(((IAlumno)ite.actual()));
		}
		public void next(){
			ite.siguiente();
		}
	
}
}