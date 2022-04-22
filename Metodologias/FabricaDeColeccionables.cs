/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 21/4/2022
 * Hora: 15:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Semana1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	abstract public class FabricaDeColeccionables:IFabricaDeColeccionables {
		//Paso 1.1 Metodo de clase.Static
		
		public static Coleccionable crearColeccionable(int queProducto){
			//Crear una fabrica concreta que sepa crear el tipo de producto que nos piden
			FabricaDeColeccionables fabrica = null;
			switch(queProducto){
					//No crea productos,sabe y crea la fabrica concreta que sabe crear ese producto
					case 1: fabrica = new FabricaDePila(); break;
					case 2: fabrica = new FabricaDeCola(); break;
					case 3: fabrica = new FabricaDeColeccionMultiple(); break;
					case 4: fabrica = new FabricaDeConjunto(); break;
					case 5: fabrica = new FabricaDeDiccionario(); break;
			}
			return fabrica.crearColeccionable();
		}
		
		//Paso 1.2 Metodo de instancia
		
	 //Toda jerarquia completa tiene que saber crear el producto
		abstract public Coleccionable crearColeccionable();
	}
	
	public class FabricaDePila:FabricaDeColeccionables{
		override public Coleccionable crearColeccionable(){
			Pila p = new Pila();
			return p;
		}

	}
	
	public class FabricaDeCola:FabricaDeColeccionables{
		override public Coleccionable crearColeccionable(){
			Cola c = new Cola();
			return c;
		}

	}
	
	public class FabricaDeColeccionMultiple:FabricaDeColeccionables{
		override public Coleccionable crearColeccionable(){
			Pila p = new Pila();
			Cola c= new Cola();
			ColeccionMultiple cm= new ColeccionMultiple(p,c);
			return cm;
		}

	}
	
	public class FabricaDeConjunto:FabricaDeColeccionables{
		override public Coleccionable crearColeccionable(){
			Conjunto conj = new Conjunto();
			return conj;
		}

	}
	
	public class FabricaDeDiccionario:FabricaDeColeccionables{
		override public Coleccionable crearColeccionable(){
			Diccionario dic = new Diccionario();
			return dic;
		}

	}
}
