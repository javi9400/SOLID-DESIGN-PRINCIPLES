using System.Collections.Generic;
using OpenClosedPrincipleExample.Domain;

namespace OpenClosedPrincipleExample.Application{

    public class SancionCalculator{

        private readonly IEnumerable<Sancion> _sanciones;

        public SancionCalculator(List<Sancion> sanciones)
        {

            this._sanciones=sanciones;
            
        }

        public double CalcularTotalSanciones(){
            double totalSanciones=0d;

            foreach (var item in _sanciones)
            {
                // Que tal si nos agregan que para el impuesto 208 se dara descuento? 
                // if impuesto 208 
                // esto haria que nos llenaramos de if 
                
                totalSanciones=item.ImpuestoAPagar+item.SalarioMinimo;
                
            }

            return totalSanciones;

        }
        
    }
}