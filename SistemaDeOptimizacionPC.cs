using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // Variables que almacenan los datos de la computadora
    static bool pcLenta;
    static double espacioDisco;
    static double usoRAM;
    static bool programasLentos;
    static bool erroresDisco;

    static void Main(string[] args)
    {
        Console.WriteLine("==========================================");
        Console.WriteLine(" SISTEMA EXPERTO - OPTIMIZACION DE PC");
        Console.WriteLine("==========================================");

        // Captura de información
        Console.WriteLine("\n--- DATOS DE LA COMPUTADORA ---");

        pcLenta = LeerSiNo("¿La computadora presenta lentitud? (s/n): ");

        Console.Write("¿Cuanto espacio disponible tiene el disco? (%): ");
        espacioDisco = LeerNumero();

        Console.Write("¿Que porcentaje de memoria RAM esta utilizando? (%): ");
        usoRAM = LeerNumero();

        programasLentos = LeerSiNo(
            "¿Los programas responden lentamente? (s/n): ");

        erroresDisco = LeerSiNo(
            "¿Se han detectado errores en el disco? (s/n): ");

        // Evaluación de las reglas
        EvaluarReglas();

        Console.WriteLine("\n==========================================");
        Console.WriteLine(" Presione una tecla para salir...");
        Console.ReadKey();
    }

    // Método para evaluar las cinco reglas
    static void EvaluarReglas()
    {
        bool seActivoUnaRegla = false;

        Console.WriteLine("\n========== RESULTADOS ==========");

        // REGLA 1: Diagnóstico de almacenamiento
        if (pcLenta == true && espacioDisco < 15)
        {
            Console.WriteLine("\n[R1] DIAGNOSTICO:");
            Console.WriteLine("Almacenamiento insuficiente.");
            seActivoUnaRegla = true;
        }

        // REGLA 2: Diagnóstico de memoria RAM
        if (usoRAM > 90 && programasLentos == true)
        {
            Console.WriteLine("\n[R2] DIAGNOSTICO:");
            Console.WriteLine("Consumo elevado de memoria RAM.");
            seActivoUnaRegla = true;
        }

        // REGLA 3: Recomendación de almacenamiento
        if (espacioDisco < 15)
        {
            Console.WriteLine("\n[R3] RECOMENDACION:");
            Console.WriteLine("Eliminar archivos temporales y liberar espacio.");
            seActivoUnaRegla = true;
        }

        // REGLA 4: Recomendación de memoria RAM
        if (usoRAM > 90)
        {
            Console.WriteLine("\n[R4] RECOMENDACION:");
            Console.WriteLine("Cerrar programas innecesarios para liberar RAM.");
            seActivoUnaRegla = true;
        }

        // REGLA 5: Recomendación de revisión del disco
        if (erroresDisco == true)
        {
            Console.WriteLine("\n[R5] RECOMENDACION:");
            Console.WriteLine("Ejecutar una herramienta de comprobacion del sistema de archivos.");
            seActivoUnaRegla = true;
        }

        // Si ninguna regla se cumple
        if (seActivoUnaRegla == false)
        {
            Console.WriteLine("\nNo se encontraron problemas segun las reglas establecidas.");
            Console.WriteLine("La computadora presenta condiciones normales.");
        }

        Console.WriteLine("\n================================");
    }

    // Método para leer respuestas de tipo SI o NO
    static bool LeerSiNo(string mensaje)
    {
        string respuesta;

        while (true)
        {
            Console.Write(mensaje);
            respuesta = Console.ReadLine().Trim().ToLower();

            if (respuesta == "s")
            {
                return true;
            }
            else if (respuesta == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Ingrese solamente s o n.");
            }
        }
    }

    // Método para leer valores numéricos
    static double LeerNumero()
    {
        double numero;

        while (true)
        {
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero)
                && numero >= 0 && numero <= 100)
            {
                return numero;
            }

            Console.Write("Ingrese un numero entre 0 y 100: ");
        }
    }
}

