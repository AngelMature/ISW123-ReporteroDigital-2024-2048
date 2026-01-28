using System;

namespace ReporteroDigital.Excepciones
{
    public class FuenteNoDisponibleException : Exception
    {
        public FuenteNoDisponibleException(string mensaje) : base(mensaje) { }
    }
}