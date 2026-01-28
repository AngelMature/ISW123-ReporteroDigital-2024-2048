using System;
using System.Threading.Tasks;

namespace ReporteroDigital
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Nombre: Angel Mature");
            Console.WriteLine("Matrícula: 2024-2048");
            Console.WriteLine("====================================");
            Console.WriteLine("=== Reportero Digital Dominicano ===");

            Reportero reportero = new Reportero();

            reportero.ArticuloGenerado += mensaje =>
            {
                Console.WriteLine($"EVENTO: {mensaje}");
            };

            await reportero.GenerarArticuloAsync();

            Console.WriteLine("Proceso finalizado.");
        }
    }
}