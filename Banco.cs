/*
 * Created by SharpDevelop.
 * User: Compumar
 * Date: 21/10/2025
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace tp.final
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco
	{
		//ATRIBUTOS PRIVADOS
		private string nombre;
		private List<Cliente> clientes;
		private List<Cuenta> cuentas;
		
		public string Nombre//prpiedad
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
		// Propiedad PÚBLICA de SOLO LECTURA para la lista/PARA MODIFICAR LISRTA SE ACCEDE SOLO A TRAVES DE LOS METODOS
		
		public List<Cliente> Clientes
        {
            get { return this.clientes; } // Devuelve la lista
            // NO HAY 'set' -> No se puede hacer miBanco.Clientes = new List<Cliente>(); desde afuera
        }

        
        public List<Cuenta> Cuentas 
        {
            get { return this.cuentas; } 
            
        }
		
		//CONSTRUCTOR PARAMETRIZADO
		
		public Banco(string nombre)
        {
            // Usamos la Propiedad para asignar el nombre
            this.Nombre = nombre; 
            
            // Creamos las listas VACÍAS (pero estan null porque aun no cargu{e ddatos)
            this.clientes = new List<Cliente>(); 
            this.cuentas = new List<Cuenta>();
        }
		
		public Banco()//constructor por defecto
		{
		}
		
		//MÉTODOSlista cuentas
		public void AgregarCuenta(Cuenta unaCuenta)
        {
         // Agrega la cuenta recibida al final de la lista privada
         this.cuentas.Add(unaCuenta); 
          }

        public void EliminarCuenta(Cuenta unaCuenta)
        {
         // Elimina la primera aparición de la cuenta recibida en la lista privada
         this.cuentas.Remove(unaCuenta); 
         }

         public int CantidadCuentas()
         {
           // Devuelve cuántos elementos hay en la lista privada
           return this.cuentas.Count; 
         }

        public bool ExisteCuenta(Cuenta unaCuenta)
        {
           // Verifica si la cuenta recibida ya existe en la lista
         return this.cuentas.Contains(unaCuenta); 
         }

        public Cuenta VerCuenta(int i)
         {
         // Devuelve el objeto Cuenta que está en la posición 'i' de la lista privada. Si 'i' esta fuera de rango, esto da un error ( IndexOutOfRangeException).
              return this.cuentas[i]; 
          }

         public List<Cuenta> TodasLasCuentas()
        {
          // Devuelve la referencia a la lista privada completa
          return this.cuentas; 
         }
         
         //metyodo en listA CUENTA
      
      // 1. Agregar CIENTE AL FINAL DE LA LISTA
       public void AgregarCliente(Cliente unCliente)
         {
           this.clientes.Add(unCliente); 
         }

      // 2. Eliminar la primera aparición del cliente recibido en la lista
       public void EliminarCliente(Cliente unCliente)
         {
    
          this.clientes.Remove(unCliente); 
         }

      // 3. Cantidad (Count) Devuelve cuántos elementos hay en la lista
        public int CantidadClientes()
         {
           return this.clientes.Count;
         }

       // 4. Existe Verifica si el cliente recibido ya existe en la lista
        public bool ExisteCliente(Cliente unCliente)
        {
         return this.clientes.Contains(unCliente); 
        }

       // 5. Ver por índice Devuelve el objeto Cliente que está en la posición 'i' de la lista
       public Cliente VerCliente(int i)
       {
         return this.clientes[i]; 
       }
   
       // 6. Ver todos, devuelve la referencia a la lista
       public List<Cliente> TodosLosClientes()
       {
         return this.clientes; 
       }
         
       public Cliente BuscarClientePorDNI(string dni)
       {
           foreach (Cliente clienteActual in this.clientes)  //  Recorrer la lista de clientes
           {
            if (clienteActual.Dni == dni) //Comparar el DNI
            {
            // 
            return clienteActual; //si lo encuentra devuelve este cliente
             }
            }        
           return null; // Si el bucle termina y no se encontro.e devuelve null.
       }
       
       public Cuenta BuscarCuentaPorNro(string nro) 
       {
           foreach (Cuenta cuentaActual in this.cuentas)
           {
             if (cuentaActual.Numero == nro)
             {
              return cuentaActual;
              }
             }
 
         return null;
       }
       
       
       
	}
}
