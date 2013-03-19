using System;

namespace herencia
{
	public class principal:padre2
	{
		protected string nombreHijo; 
		
		public principal ()
		{			
			this.nombreHijo = " ";  
		}
		
		public  override String  metodoHerencia(  )
		{	
			return "NOMBRE DEL PADRE:  " +"  "+this.nombrePadre  +"  "+ this.apellidoPadre +"\n"+ 
				   "NOMBRE DE LA MADRE " +"  "+ this.nombreMadre +"  "+ this.apellidoMadre +"\n"+
				   "NOMBRE DEL HIJO    " +"  "+ this.nombreHijo  +"  "+ this.apellidoPadre +"  "+ this.apellidoMadre; 
		}
		public  void capturaNombreHijo(){
			Console.WriteLine ("NOMBRE DEL HIJO");
			this.nombreHijo = Console.ReadLine (); 	
		}
	}
}
