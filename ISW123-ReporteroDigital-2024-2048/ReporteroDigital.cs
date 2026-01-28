using System;
using System.Threading.Tasks;
using ReporteroDigital.Excepciones;

namespace ReporteroDigital
{
    public class Reportero
    {
        public event Action<string> ArticuloGenerado;

        
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