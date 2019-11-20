namespace OpenClosedPrincipleExample.Domain
{
    public class Sancion
    {
        public int Impuesto { get; set; }
        public double ImpuestoAPagar { get; set; }
        public double SalarioMinimo{get;set;}
       
        public Sancion(int impuesto, double impuestoAPagar, double salarioMinimo)
        {
            Impuesto=impuesto;
            ImpuestoAPagar=impuestoAPagar;
            SalarioMinimo=salarioMinimo;
            
        }

        public Sancion()
        {
            
        }
    }
}