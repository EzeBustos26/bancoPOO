/*
 * Created by SharpDevelop.
 * User: Compumar
 * Date: 21/10/2025
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace tp.final
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Banco miBanco = new Banco("Nombre Del Banco");
			string rutaArchivoClientes = "clientes.csv";
            string rutaArchivoCuentas="cuentas.csv";			

               
           //cargar clientes desde funcion
            CargarClientesDesdeArchivo(miBanco, rutaArchivoClientes);
               
           //cargar cuentas desde funcion
            CargarCuentasDesdeArchivo(miBanco,rutaArchivoCuentas);
            
            
           // Empezar con el menú
           
           int opcion=0 ; // Variable para guardar la opción del usuario

do 
{              
	              Console.Clear();
                
                Console.WriteLine("Operaciones bancarias");
                mostrarMenu();
                Console.Write("Ingrese una opción: ");
                opcion=Convert.ToInt32(Console.ReadLine());  
   

    // 3. Usar un switch para manejar la opción
    switch (opcion)
    {
        case 1:
            // Lógica para agregar cuenta...
            break;
        case 2:
            // Lógica para eliminar cuenta...
            break;
        case 3:
            // Lógica para eliminar cuenta...
            break;
        case 4:
            // Lógica para eliminar cuenta...
            break;
        case 5:
            // Lógica para eliminar cuenta...
            break;
        case 6:
            // Lógica para eliminar cuenta...
            break;
        case 7:
            // Lógica para eliminar cuenta...
            break;
        case 8:
            // Lógica para eliminar cuenta...
            break;
        case 9:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("El número ingresado no representa una opcion de este menú.");
            break;
    }
   

} while (opcion != 9); // La condición: Repetir mientras la opción NO sea "x"


    		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		//cargar clientes desde archivo

        public static void CargarClientesDesdeArchivo(Banco miBanco, string rutaArchivoClientes)
        {
            if (File.Exists(rutaArchivoClientes)) 
            {
            // Agregar bloque try aquí para manejar errores de archivo/formato?
                Console.WriteLine("Archivo de clientes encontrado. Cargando...");
             using(StreamReader lecturaArchivo= new StreamReader(rutaArchivoClientes))//se crea un objeto de tipo streamreader
             {
                string linea;//se declara una variable
                while( (linea= lecturaArchivo.ReadLine())!= null)//en esa variable se guarda la lectura del archivo y si es distinta de null , entra al while
                {
                	Console.WriteLine( linea);
                	string[] partes= linea.Split(',');
                	Cliente nuevoCliente = new Cliente(partes[0], partes[1], partes[2],partes[3], partes[4], partes[5]);
                	miBanco.AgregarCliente(nuevoCliente);
                    List<Cliente> listaParaMostrar = miBanco.TodosLosClientes();
                }
                
             }
                    Console.WriteLine("Clientes cargados.");
               
              }
               else
              {
                 // Si se entra aca, el archivo no existe en la carpeta de ejecución.
                Console.WriteLine("ADVERTENCIA: No se encontró el archivo 'clientes.csv' en la carpeta del programa.");
               }
        }
        
        public static void CargarCuentasDesdeArchivo(Banco miBanco,string rutaArchivoCuentas)
        { if (File.Exists(rutaArchivoCuentas))
        	{
        		    Console.WriteLine("Archivo de clientes encontrado. Cargando...");
             using(StreamReader lecturaCuentas= new StreamReader(rutaArchivoCuentas))//se crea un objeto de tipo streamreader
             {
                string linea;//se declara una variable
                while( (linea=lecturaCuentas.ReadLine())!= null)//en esa variable se guarda la lectura del archivo y si es distinta de null , entra al while
                {
                	Console.WriteLine(linea);
                	string[] partes= linea.Split(',');
                	try // Añadido para capturar error si el saldo no es un número
                    {
                	 double saldoInicial = double.Parse(partes[4]);
                	
                	Cuenta nuevaCuenta= new Cuenta(partes[0], partes[1], partes[2],partes[3], saldoInicial);
                	
                	miBanco.AgregarCuenta(nuevaCuenta);
                    List<Cuenta> listaParaMostrar = miBanco.TodasLasCuentas();
                    }
                    catch (FormatException) // Error si partes[4] no es un número double válido
                    {
                         Console.WriteLine("ADVERTENCIA: Saldo inválido en línea: " + linea);
                    }
                    catch (IndexOutOfRangeException) // Error s
                    {
                         Console.WriteLine("ADVERTENCIA: Faltan datos en línea:" + linea);
                    }
                }
                
             }
                    Console.WriteLine("Cuentas cargadas.");
               
              }
               else
              {
                 // Si se entra aca, el archivo no existe en la carpeta de ejecución.
                Console.WriteLine("ADVERTENCIA: No se encontró el archivo 'clientes.csv' en la carpeta del programa.");
               }
        	}
        
        static void mostrarMenu(){
			Console.WriteLine("1. Agregar una cuenta al banco.");
		    Console.WriteLine("2. Eliminar una cuenta");
		    Console.WriteLine("3.Listado de clientes que tienen más de una cuenta");
		    Console.WriteLine("4.Listado de clientes");
		    Console.WriteLine("5.Listado de cuenta");
		    Console.WriteLine("6.Realizar una extracción.");
            Console.WriteLine("7.Depositar dinero");
            Console.WriteLine("8.Transferir dinero"); 
		    Console.WriteLine("9.Salir");
		}
		
		
	}
}