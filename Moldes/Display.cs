using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    public class Display
    {
         public static void Cuadrado()
        {
            System.IO.StreamReader archivo = null;
            
            try
            {
                string linea;
                archivo = new System.IO.StreamReader(@"..\..\..\Txt\Cuadrado.txt");
                while ((linea = archivo.ReadLine()) != null) Console.WriteLine(linea);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en la lectura del archivo 'Cuadrado.txt': {e.Message}");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine();
                }
            }
        }


        public static void Rectangulo()
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                archivo = new System.IO.StreamReader(@"..\..\..\Txt\Rectangulo.txt");
                while ((linea = archivo.ReadLine()) != null) Console.WriteLine(linea);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en la lectura del archivo 'Rectangulo.txt': {e.Message}");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine();
                }
            }
        }

        
         public static void Trapecio()
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                archivo = new System.IO.StreamReader(@"..\..\..\Txt\Trapecio.txt");
                while ((linea = archivo.ReadLine()) != null) Console.WriteLine(linea);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en la lectura del archivo 'Trapecio.txt': {e.Message}");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine();
                }
            }
        }

        public static void Reset()
        {
            Console.WriteLine();
            Console.Write("Pulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

    }
}