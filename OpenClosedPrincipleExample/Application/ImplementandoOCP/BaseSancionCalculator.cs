using OpenClosedPrincipleExample.Domain;

namespace OpenClosedPrincipleExample.Application.ImplementandoOCP
{
    public abstract class BaseSancionCalculator{
        protected Sancion Sancion{get;set;}
        
        public BaseSancionCalculator(Sancion sancion)
        {
            Sancion=sancion;
        }

        public abstract double CalcularTotalSanciones();
       
    }

    
}