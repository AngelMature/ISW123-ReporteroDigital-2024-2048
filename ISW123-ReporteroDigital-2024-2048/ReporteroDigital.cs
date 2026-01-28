using System;
using System.Threading.Tasks;
using ReporteroDigital.Excepciones;

namespace ReporteroDigital
{
    public class Reportero
    {
        public event Action<string> ArticuloGenerado;

        public async Task GenerarArticuloAsync()
        {
            try
            {
                var textoTask = ObtenerTextoAsync();
                var imagenTask = ObtenerImagenAsync();
                var analisisTask = ObtenerAnalisisAsync();

                await Task.WhenAll(textoTask, imagenTask, analisisTask);

                string articulo =
                    $"{textoTask.Result}\n{imagenTask.Result}\n{analisisTask.Result}";

                ArticuloGenerado?.Invoke("Artículo generado exitosamente.");
                Console.WriteLine(articulo);
            }
            catch (FuenteNoDisponibleException ex)
            {
                Console.WriteLine($"Advertencia: {ex.Message}");
            }
        }

        private async Task<string> ObtenerTextoAsync()
        {
            await Task.Delay(1000);
            return " Texto principal de la noticia.";
        }

        private async Task<string> ObtenerImagenAsync()
        {
            await Task.Delay(1200);
            return " Imagen cargada correctamente.";
        }

        private async Task<string> ObtenerAnalisisAsync()
        {
            await Task.Delay(800);
            throw new FuenteNoDisponibleException("No se pudo obtener el análisis.");
        }
    }
}