using System;

namespace herencia
{
	class MainClass
	{
		public void capturaDatos(){
			principal datos = new principal (); 

			Console.WriteLine ("Nombre del padre");
			datos.nombrePadre = Console.ReadLine ();
			Console.WriteLine ("Apellido del padre paterno");
			datos.apellidoPadre = Console.ReadLine (); 

			Console.WriteLine ("Nombre de la madre ");
			datos.nombreMadre = Console.ReadLine ();
			Console.WriteLine ("Apellido de la madre paterno");
			datos.apellidoMadre = Console.ReadLine (); 

			datos.capturaNombreHijo (); 
			datos.metodoHerencia (); 

			Console.WriteLine (datos.metodoHerencia());
		}
		public static void Main (string[] args)
		{
			MainClass objeto = new MainClass ();
			objeto.capturaDatos ();
			
		}
	}
}