using System.Collections.Generic;
using OpenClosedPrincipleExample.Domain;

namespace OpenClosedPrincipleExample.Application.ImplementandoOCP.NuevaSancionCalculator{

    public class SancionCalculator{

        private readonly IEnumerable<BaseSancionCalculator> _sanciones;

        public SancionCalculator(List<BaseSancionCalculator> sanciones)
        {

            this._sanciones=sanciones;
            
        }

        public double CalcularTotalSanciones(){
            double totalSanciones=0d;

            foreach (var item in _sanciones)
            {
               
                
                totalSanciones=item.CalcularTotalSanciones();
                
            }

            return totalSanciones;

        }
        
    }
}