using System.ComponentModel.DataAnnotations;
using System;
using Clase16_Ejercicio.Moldes;

double Aux1;
double Aux2;
double Aux3;
string Respuesta1;
string Respuesta2;
string Respuesta3;
do
{
    Console.WriteLine("¿A que figura quiere calcular el área?");
    Console.WriteLine("1- Cuadrado.");
    Console.WriteLine("2- Rectángulo.");
    Console.WriteLine("3- Trapecio.");
    Console.WriteLine("0 - Salir");
    Respuesta1 = Console.ReadLine();

    if (Respuesta1 == "0") break;
    Console.Clear();

    switch (Respuesta1)
    {
        case "1":
            do
            {
                Display.Cuadrado();
                Console.Write("Ingrese la coordenada 'X' del Vertice 'C': ");
                Respuesta1 = Console.ReadLine();
                Aux1 = Verificar.VerificarNum(Respuesta1);
                if (Aux1 != -1)
                {
                    Cuadrado Figura1 = new Cuadrado(Aux1);
                    Console.WriteLine();
                    Console.WriteLine($"El área del cuadrado es {Figura1.CalculoArea()}");
                    Display.Reset();
                }
                else
                {
                    Console.Write("Quiere volver a intentar calcular el área de un cuadrado? s/n ");
                    Respuesta1 = Console.ReadLine();
                    Respuesta1 = Verificar.VerificarSiNo(Respuesta1);
                    Display.Reset();
                }

            } while (Respuesta1.ToUpper() == "S");
            break;
        case "2":
            do
            {
                Display.Rectangulo();
                Console.Write("Ingrese la coordenada 'X' del Vertice 'C' correspondiente a la base: ");
                Respuesta1 = Console.ReadLine();
                Console.Write("Ingrese la coordenada 'Y' del vértice 'A' correcpondiente a la altura: ");
                Respuesta2 = Console.ReadLine();

                Aux1 = Verificar.VerificarNum(Respuesta1);
                Aux2 = Verificar.VerificarNum(Respuesta2);
                if (Aux1 != -1 & Aux2 != -1)
                {
                    Rectangulo Figura2 = new Rectangulo(Aux1, Aux2);
                    Console.WriteLine();
                    Console.WriteLine($"El área del rectángulo es {Figura2.CalculoArea()}");
                    Display.Reset();
                }
                else
                {
                    Console.Write("Quiere volver a intentar calcular el área de un rectángulo? s/n ");
                    Respuesta1 = Console.ReadLine();
                    Respuesta1 = Verificar.VerificarSiNo(Respuesta1);
                    Display.Reset();
                }

            } while (Respuesta1.ToUpper() == "S");
            break;
        case "3":
            do
            {
                Display.Trapecio();
                Console.Write("Ingrese la coordenada 'X' del vértice 'A' correspondiente al inicio de la base menor: ");
                Respuesta1 = Console.ReadLine();
                Console.Write("Ingrese la coordenada 'Y' del vértice 'A' correspondiente a la altura: ");
                Respuesta2 = Console.ReadLine();
                Console.Write($"Ingrese la coordenada 'X' del vértice 'C' correspondiente a la Base mayor. Este debe ser mayor a {Respuesta1}: ");
                Respuesta3 = Console.ReadLine();
                
                Aux1 = Verificar.VerificarNum(Respuesta1);
                Aux2 = Verificar.VerificarNum(Respuesta2);
                Aux3 = Verificar.VerificarNum(Respuesta3);

                if (Aux3 <= Aux1)
                {
                    Aux3 = -1;
                    Console.WriteLine();
                    Console.WriteLine("La coordenada 'X' del vértice 'C' es inválida. Esta debe ser mayor que la coordenada 'X' del vértice 'A' para que la Base mayor tenga una mayor longitud.");
                    Console.WriteLine();
                }

                if (Aux1 != -1 & Aux2 != -1 & Aux3 != -1)
                {
                    Trapecio Figura3 = new Trapecio(Aux1, Aux2, Aux3);
                    Console.WriteLine();
                    Console.WriteLine($"El área del trapecio es {Figura3.CalculoArea()}");
                    Display.Reset();
                }
                else
                {                    
                    Console.Write("Quiere volver a intentar calcular el área de un trapecio? s/n ");
                    Respuesta1 = Console.ReadLine();
                    Respuesta1 = Verificar.VerificarSiNo(Respuesta1);
                    Display.Reset();
                }

            } while (Respuesta1.ToUpper() == "S");
            break;        
        default:
            Console.WriteLine("¡Ingresó una opcion inválida!");
            break;
    }
} while (true);