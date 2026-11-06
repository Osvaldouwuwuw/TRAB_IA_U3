using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // 1. VARIABLES DE ENTRADA

    // A: Computadora lenta
    static bool A = true;

    // B: Espacio disponible en disco
    static double B = 10;

    // C: Uso de memoria RAM
    static double C = 95;

    // D: Programas lentos
    static bool D = true;

    // E: Errores en el disco
    static bool E = true;

    // 2. VARIABLES DE SALIDA

    // F: Diagnostico de almacenamiento insuficiente
    static bool F = false;

    // G: Diagnostico de consumo elevado de RAM
    static bool G = false;

    // H: Recomendacion para liberar espacio
    static bool H = false;

    // I: Recomendacion para liberar memoria RAM
    static bool I = false;

    // J: Recomendacion para comprobar el disco
    static bool J = false;

    // 3. LISTA DE HECHOS

    static List<string> listaHechos = new List<string>();

    // 4. PROGRAMA PRINCIPAL

    static void Main(string[] args)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("   SISTEMA EXPERTO PARA OPTIMIZAR UNA PC");
        Console.WriteLine("==============================================");

        // Registrar los hechos iniciales
        RegistrarHechosIniciales();

        // Mostrar los datos analizados
        Console.WriteLine("\n--- ESTADO DE LA COMPUTADORA ---");

        Console.WriteLine("A - Computadora lenta: " + (A ? "Si" : "No"));
        Console.WriteLine("B - Espacio disponible en disco: " + B + "%");
        Console.WriteLine("C - Uso de memoria RAM: " + C + "%");
        Console.WriteLine("D - Programas lentos: " + (D ? "Si" : "No"));
        Console.WriteLine("E - Errores en disco: " + (E ? "Si" : "No"));

        // Ejecutar el motor de inferencia
        EvaluarReglas();

        // Mostrar los hechos generados
        MostrarListaHechos();

        // Mostrar las variables de salida
        MostrarVariablesSalida();

        Console.WriteLine("\n==============================================");
        Console.WriteLine(" ANALISIS FINALIZADO");
        Console.WriteLine("==============================================");

        Console.ReadKey();
    }

    // 5. REGISTRO DE HECHOS INICIALES
 
    static void RegistrarHechosIniciales()
    {
        if (A == true)
            listaHechos.Add("A: Computadora lenta");

        if (B < 15)
            listaHechos.Add("B: Espacio disponible en disco menor al 15%");

        if (C > 90)
            listaHechos.Add("C: Uso de memoria RAM mayor al 90%");

        if (D == true)
            listaHechos.Add("D: Programas lentos");

        if (E == true)
            listaHechos.Add("E: Errores detectados en el disco");
    }

    // 6. MOTOR DE INFERENCIA

    static void EvaluarReglas()
    {
        bool reglaActivada = false;

        Console.WriteLine("\n--- EVALUACION DE LAS REGLAS ---");


        // REGLA 1: A Y B -> F
        if (A == true && B < 15)
        {
            Console.WriteLine("\n[R1] DIAGNOSTICO:");
            Console.WriteLine("Almacenamiento insuficiente.");

            F = true;
            listaHechos.Add("F: Diagnostico de almacenamiento insuficiente");

            reglaActivada = true;
        }


        // REGLA 2: C Y D -> G
        if (C > 90 && D == true)
        {
            Console.WriteLine("\n[R2] DIAGNOSTICO:");
            Console.WriteLine("Consumo elevado de memoria RAM.");

            G = true;
            listaHechos.Add("G: Diagnostico de consumo elevado de RAM");

            reglaActivada = true;
        }


        // REGLA 3: B -> H
        if (B < 15)
        {
            Console.WriteLine("\n[R3] ACCION:");
            Console.WriteLine("Eliminar archivos temporales y liberar espacio.");

            H = true;
            listaHechos.Add("H: Recomendar eliminar archivos temporales");

            reglaActivada = true;
        }


        // REGLA 4: C -> I
        if (C > 90)
        {
            Console.WriteLine("\n[R4] ACCION:");
            Console.WriteLine("Cerrar programas innecesarios para liberar RAM.");

            I = true;
            listaHechos.Add("I: Recomendar cerrar programas innecesarios");

            reglaActivada = true;
        }


        // REGLA 5: E -> J
        if (E == true)
        {
            Console.WriteLine("\n[R5] ACCION:");
            Console.WriteLine("Ejecutar una herramienta de comprobacion del disco.");

            J = true;
            listaHechos.Add("J: Recomendar comprobar el sistema de archivos");

            reglaActivada = true;
        }


        // Verificar si alguna regla se activo
        if (reglaActivada == false)
        {
            Console.WriteLine("\nNo se detectaron problemas.");
            Console.WriteLine("El rendimiento de la PC parece normal.");
        }
    }

    // 7. MOSTRAR LISTA DE HECHOS

    static void MostrarListaHechos()
    {
        Console.WriteLine("\n--- LISTA DE HECHOS ---");

        foreach (string hecho in listaHechos)
        {
            Console.WriteLine(hecho);
        }
    }

    // 8. MOSTRAR VARIABLES DE SALIDA

    static void MostrarVariablesSalida()
    {
        Console.WriteLine("\n--- VARIABLES DE SALIDA ---");

        Console.WriteLine("F - Almacenamiento insuficiente: " + F);
        Console.WriteLine("G - Consumo elevado de RAM: " + G);
        Console.WriteLine("H - Liberar espacio en disco: " + H);
        Console.WriteLine("I - Optimizar memoria RAM: " + I);
        Console.WriteLine("J - Comprobar errores del disco: " + J);
    }
}

