using System;

namespace Forma_de_pago_efectivo_o_tarjeta
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio = 0;
            string dato = "";
            string forma_pagar = "";
            string digitos = "";

            Console.Write("Dame el precio de un producto: ");
            dato = Console.ReadLine();
            precio = Convert.ToInt32(dato);

            Console.Write("De que forma quiere pagar: ");
            forma_pagar = Console.ReadLine();

            if (forma_pagar == "tarjeta")
            {
                Console.Write("Ingrese numero de tarjeta: ");
                digitos = Console.ReadLine();
                Console.WriteLine("Gracias por su compra");
            }
            if (forma_pagar == "efectivo")
            {
                Console.Write("Gracias por su compra.");
            }   
        }
    }
}
