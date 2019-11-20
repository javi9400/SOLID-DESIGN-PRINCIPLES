namespace LiskovSubstitutionPrincipleExample.Domain
{
    public class DescuentoDecreto180 : DescuentoDecreto170
    {
       
        public DescuentoDecreto180(double valorSanciones, double valorTotalPago) : base(valorSanciones, valorTotalPago)
        {
        }
    }
}