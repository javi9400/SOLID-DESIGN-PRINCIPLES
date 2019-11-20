using System;
using LiskovSubstitutionPrinciple.Application;
using LiskovSubstitutionPrinciple.Domain;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            DescuentoDecreto170 descuento1 = new DescuentoDecreto170(500,200);
            System.Console.WriteLine("Total DescuentoDecreto170 10% es : {0}",CalculadoraDeDescuento.CalcularDescuento(descuento1));

            DescuentoDecreto220 descuento2 = new DescuentoDecreto220(500,200);
            System.Console.WriteLine("Total DescuentoDecreto220 50% es : {0}",CalculadoraDeDescuento.CalcularDescuento(descuento1));


            DescuentoDecreto170 descuento3= new DescuentoDecreto220(500,200);

            //Aqui preguntamos que valor aplicara el 10
            System.Console.WriteLine("Total DescuentoDecreto220 50% es : {0}",CalculadoraDeDescuento.CalcularDescuento(descuento1));

        }
    }
}
