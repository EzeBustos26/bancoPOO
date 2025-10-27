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
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		//atributos
		
		private string nombreCliente;
	    private string apellidoCliente;
        private	string dni;
        private string direccion;
        private string telefono;
		private string mail;
					
			//METODO DESCRIPTOR DE ACCESO PARA ACCEDER A LAS PROPIEDADES
		
		public string NombreCliente{
			get{return this.nombreCliente;}
			set { this.nombreCliente = value; }
		}
		
		public string ApellidoCliente{
			get{return this.apellidoCliente;}
			set { this.apellidoCliente = value; }
			
		}
		
		public string Dni{
			get{return this.dni;}
			set{this.dni= value;}
			}
			
	    public string Direccion{
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string Telefono {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string Mail {
            get { return this.mail; }
            set { this.mail = value; }
        }
		
		//Constructores

		public Cliente()//constructor por defecto
		{
				
		}
		
		public Cliente(string nombre, string apellido, string dni, string direccion,string telefono,string mail)//constructor parametrizado//asignar el valor usando la Propiedad pública
		{ this.NombreCliente=nombre;
		  this.ApellidoCliente=apellido;
		  this.Dni=dni;
		  this.Direccion= direccion;
		  this.Telefono= telefono;
		  this.Mail=mail;

		}
		
		//mETODO PARA mOSTRAR DATOS
		
		public void MostrarDatos(){
			Console.WriteLine("---- Información de la persona ----");
            Console.WriteLine("Nombre: " + NombreCliente);
            Console.WriteLine("Apellido: " + ApellidoCliente);
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Telefono: " + Telefono);
            Console.WriteLine("Mail: " + Mail);
            
		}
	}
}
