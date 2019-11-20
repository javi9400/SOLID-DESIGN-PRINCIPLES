namespace LiskovSubstitutionPrincipleExample.Domain
{
public class DescuentoDecreto100:Descuento
    {
        public virtual double ValorTotalSanciones { get; set; }
        public virtual double ValorTotalPago { get; set; }
        public DescuentoDecreto100(double valorTotalPago,double valorSanciones)
        {
          
            this.ValorTotalPago=valorTotalPago;
            this.ValorTotalSanciones=valorSanciones;
        }

        public DescuentoDecreto100()
        {
        }

        public override double CalcularCredito()
        {
           double valorCredito=0d;

           valorCredito=this.ValorTotalPago-this.ValorTotalSanciones;
           valorCredito=valorCredito*0.10; 

          return valorCredito;
        }
    }

}