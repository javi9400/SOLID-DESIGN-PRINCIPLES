namespace LiskovSubstitutionPrinciple.Domain
{
    public class DescuentoDecreto220 : DescuentoDecreto170
    {
        public DescuentoDecreto220(double valorTotalPagado, double valorTotalSanciones) : base(valorTotalPagado, valorTotalSanciones)
        {
        }
        public override double CalcularCredito(double ValorTotalPagado, double valorTotalSanciones)
        {
            double valorCreditoAplicar=0;
            valorCreditoAplicar= ValorTotalPagado-valorTotalSanciones;

            return valorCreditoAplicar*10;

        }
    }
}