using System;
using System.Collections.Generic;
using OpenClosedPrincipleExample.Application;
using OpenClosedPrincipleExample.Application.ImplementandoOCP;
using OpenClosedPrincipleExample.Domain;
using OpenClosedPrincipleExample.Application.ImplementandoOCP.NuevaSancionCalculator;

namespace OpenClosedPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sancionesPrueba= new List<Sancion>()
            {
                new Sancion{
                    Impuesto=101,
                    ImpuestoAPagar=1000,
                    SalarioMinimo=1002
                },

                new Sancion{
                    Impuesto=102,
                    ImpuestoAPagar=1000,
                    SalarioMinimo=22
                },

            new Sancion{
                    Impuesto=201,
                    ImpuestoAPagar=999,
                    SalarioMinimo=12
                }


            };

            var totalSanciones= new Application.SancionCalculator(sancionesPrueba);
        
            System.Console.WriteLine("Total de sanciones es L.{0} ",totalSanciones);


            var calculosDeSanciones= new List<BaseSancionCalculator>(){
                new ImpuestoCervezaCalculator
                (
                  new Sancion
                  {
                    Impuesto=204,
                    SalarioMinimo=200,
                    ImpuestoAPagar=2033 
                  }

                ),

                new ImpuestosNormalesCalculator
                (
                  new Sancion
                  {
                    Impuesto=101,
                    SalarioMinimo=9999,
                    ImpuestoAPagar=122 
                  }

                )
                
            };

            var total= new Application.ImplementandoOCP.NuevaSancionCalculator.SancionCalculator(calculosDeSanciones);

             System.Console.WriteLine("Total de sanciones es L.{0} ",total);
            System.Console.ReadLine();
            
        }
    }
}
