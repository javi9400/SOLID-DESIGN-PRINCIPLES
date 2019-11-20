using System;
using System.Collections.Generic;
using LiskovSubstitutionPrincipleExample.Application;
using LiskovSubstitutionPrincipleExample.Domain;

namespace LiskovSubstitutionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DescuentoDecreto170 decreto170= new DescuentoDecreto170(500,200);
            DescuentoDecreto180 decreto180= new DescuentoDecreto180(500,200);
            

            System.Console.WriteLine("El calculo Decreto170 es: L.{0}",CalculadoraDescuento.CalcularCredito(decreto170));
            System.Console.WriteLine("El calculo Decreto180 es: L.{0}",CalculadoraDescuento.CalcularCredito(decreto180));

            DescuentoDecreto170 descuento= new DescuentoDecreto180(500,200);
            //Cual sera el resultado? 
            //El problema es que la clase DescuentoDecreto170 no es sustituible por DescuentoDecreto180 aunque esta sea una sub clase
            //Esto afecta la integridad de nuestro codigo
            //El principio Liskov establece que las clases hija deben poder reemplazar la clase padre sin comprometer integridad en nuestra aplicacion.
            

            System.Console.WriteLine("El calculo Descuento es: L.{0}",CalculadoraDescuento.CalcularCredito(descuento));

            //El problema se resuelve de la siguiente manera
            /*
              Se debe abstraer el descuento para crear una clase base que sea heredada para los tipos de descuento que existan
              
            */
            var listaDescuentos= new List<Descuento>();
            DescuentoDecreto100 descuentoDecreto100 = new DescuentoDecreto100(500, 200);
            listaDescuentos.Add(descuentoDecreto100);

            foreach (var item in listaDescuentos)
            {
                System.Console.WriteLine("Descuento es: {0} ", item.CalcularCredito());
            }
    



        }
    }
}
