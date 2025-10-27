/*
 * Created by SharpDevelop.
 * User: Compumar
 * Date: 21/10/2025
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tp.final
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	public class Cuenta
	{
		private string numero;
		private string nombreTitular;
		private string apellidoTitular;
		private string dniTitular;
		private double saldo;
		
		
			//acceder a propiedades/descriptor de acceso
		
		public string Numero{
			get{return this.numero;}
			set { this.numero = value; }
		}
		
		public string NombreTitular{
			get{return this.nombreTitular;}
			set { this.nombreTitular = value; }
			
		}
		
		public string ApellidoTitular{
			get{return this.apellidoTitular;}
			set { this.apellidoTitular = value; }
			
		}
		
		public string DniTitular{
			get{return this.dniTitular;}
			set { this.dniTitular = value; }
			
		}
		
			public double Saldo{
			get{return this.saldo;}
			private set { this.saldo = value; }
			
		}
		//constructor
		
			public Cuenta (string numero, string nombre, string apellido, string dni, double depositoInicial)//constructor parametrizado//asignar el valor usando la Propiedad pública
		{ this.Numero =numero ;
		  this.NombreTitular= nombre;
		  this.ApellidoTitular= apellido;
		  this.DniTitular= dni;
		  
		  //validacion de que el deposito inicial no sea 0
		  
		  if(depositoInicial>0){
		  	this.Saldo= depositoInicial;
		  }
		  else{
		  	this.Saldo = 0;}

		}
		public Cuenta()//constructor por defecto
		{
		}
		
	
		
		//metodos
		
		
		public void Depositar(double monto)//depositar
        {
            if (monto > 0)
            {
                this.Saldo += monto;
            }
        }
		
		public void Extraer(double monto)//extraer
		{ if((monto>0) && (monto<= Saldo)){
				this.Saldo-=monto;
				Console.Write("Usted extrajo: "+ monto);
				Console.Write("Saldo actualizado: "+ this.Saldo);
			}else{//si el mont es mayor al saldo
				throw new Exception("Saldo insuficiente");//se usa la clase exception, qe ya la tiene c#
			}
		}
		
	}
}
