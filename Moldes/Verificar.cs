using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    public class Verificar
    {
         public static Double VerificarNum(string Opcion) // Se verifica que sea un dato numerico valido
        {
            int ItemMenu;
            if (Int32.TryParse(Opcion, out ItemMenu))
            {              
                if (ItemMenu < 1)
                {
                    Console.WriteLine($"Ingresó un número inválido");
                    return -1;
                }                
                return ItemMenu;
            }
            else
            {
                Console.WriteLine("!Ingresó un dato no válido¡");
                return -1;
            }
        }

        public static string VerificarSiNo(string Respuesta) // Se verifica que sea un "S" o "N"
        {
            while (Respuesta.ToUpper() != "N" & Respuesta.ToUpper() != "S")
            {
                Console.Write("Ingreso una respuesta inválida. Quiere volver a intentar calcular el área? s/n ");
                Respuesta = Console.ReadLine();
            }

            return Respuesta;
        }

    }
}