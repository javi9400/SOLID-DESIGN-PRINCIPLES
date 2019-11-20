namespace LiskovSubstitutionPrinciple.Domain
{
    public class DescuentoDecreto170
    {
       
        public DescuentoDecreto170(double valorTotalPagado, double valorTotalSanciones)
        {
            this.ValorTotalPagado = valorTotalPagado;
            this.ValorTotalSanciones = valorTotalSanciones;
        }

        public double ValorTotalPagado { get; set; }
        public double ValorTotalSanciones { get; set; }
        
        public virtual double CalcularCredito(double ValorTotalPagado, double valorTotalSanciones)
        {
            double valorCreditoAplicar=0;
            valorCreditoAplicar= ValorTotalPagado-valorTotalSanciones;

            return valorCreditoAplicar*10;

        }
        
    }
}