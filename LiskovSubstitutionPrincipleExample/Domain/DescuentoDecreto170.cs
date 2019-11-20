namespace LiskovSubstitutionPrincipleExample.Domain
{
    public class DescuentoDecreto170
    {
        public virtual double ValorTotalSanciones { get; set; }
        public virtual double ValorTotalPago { get; set; }
        public DescuentoDecreto170(double valorTotalPago,double valorSanciones)
        {
          
            this.ValorTotalPago=valorTotalPago;
            this.ValorTotalSanciones=valorSanciones;
        }
      

    }
}