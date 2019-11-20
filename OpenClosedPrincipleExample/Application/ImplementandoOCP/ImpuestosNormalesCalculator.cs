using OpenClosedPrincipleExample.Domain;

namespace OpenClosedPrincipleExample.Application.ImplementandoOCP
{
    public class ImpuestosNormalesCalculator:BaseSancionCalculator
    {
        public ImpuestosNormalesCalculator(Sancion sancion):base(sancion)
        {

        }

        public override double CalcularTotalSanciones()
        {
           return Sancion.ImpuestoAPagar+Sancion.SalarioMinimo;
        }
    }
}