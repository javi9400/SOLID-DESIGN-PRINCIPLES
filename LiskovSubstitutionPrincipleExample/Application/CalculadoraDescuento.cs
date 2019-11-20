using LiskovSubstitutionPrincipleExample.Domain;

namespace LiskovSubstitutionPrincipleExample.Application
{
    public class CalculadoraDescuento
    {
        public static double CalcularCredito(DescuentoDecreto170 descuento)
        {
            double valorCredito=0d;
            valorCredito=descuento.ValorTotalPago-descuento.ValorTotalSanciones;
            valorCredito=valorCredito*0.10;

            return valorCredito;
        }

        public static double CalcularCredito(DescuentoDecreto180 descuento)
        {
            double valorCredito=0d;
            valorCredito=descuento.ValorTotalPago-descuento.ValorTotalSanciones;
            valorCredito=valorCredito*0.50;

            return valorCredito;
        }
    }
}