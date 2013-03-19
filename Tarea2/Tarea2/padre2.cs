using System;

namespace herencia
{
	public  class  padre2
	{
		public string nombrePadre;
		public string apellidoPadre;
		public string nombreMadre;
		public string apellidoMadre;
		
		public padre2 ()
		{
			this.nombrePadre   = " ";
			this.apellidoPadre = " ";
			this.nombreMadre   = " ";
			this.apellidoMadre = " "; 	
		}
		public  virtual String metodoHerencia()
		{	
			return
				this.nombrePadre + this.apellidoPadre;
		}
	}
}