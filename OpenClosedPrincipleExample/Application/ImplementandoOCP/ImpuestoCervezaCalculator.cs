using OpenClosedPrincipleExample.Domain;

namespace OpenClosedPrincipleExample.Application.ImplementandoOCP
{
    public class ImpuestoCervezaCalculator:BaseSancionCalculator
    {
        private const double descuento=200;

        public ImpuestoCervezaCalculator(Sancion sancion):base(sancion)
        {

        }

        public override double CalcularTotalSanciones()
        {
           return Sancion.ImpuestoAPagar+Sancion.SalarioMinimo-descuento;
        }
    }
}