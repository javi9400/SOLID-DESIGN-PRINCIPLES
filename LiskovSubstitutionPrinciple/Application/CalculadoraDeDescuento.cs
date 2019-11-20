using LiskovSubstitutionPrinciple.Domain;

namespace LiskovSubstitutionPrinciple.Application
{
    public class CalculadoraDeDescuento
    {
        public static double CalcularDescuento(DescuentoDecreto170 descuento170)
        {
           double valorCreditoAplicar=0;
            valorCreditoAplicar= descuento170.ValorTotalPagado-descuento170.ValorTotalSanciones;
            
            return valorCreditoAplicar*50;
        }

        public static double CalcularDescuento(DescuentoDecreto220 descuento220)
        {

            double valorCreditoAplicar=0;
            valorCreditoAplicar= descuento220.ValorTotalPagado - descuento220.ValorTotalSanciones;
            
            return valorCreditoAplicar*50;
        }

    }
}