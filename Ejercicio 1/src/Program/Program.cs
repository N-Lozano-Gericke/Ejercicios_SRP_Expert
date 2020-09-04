using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5);
            Kiosco k = new Kiosco(); 
            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
//No cumple con Expert porque la clase alfajor tiene toda la informacion para realizar el precio de los alfajores, pero ese calculo lo realiza la clase kiosco 
//No SRP ya que kiosco tiene más de una razon de cambio