using System;

namespace TareaProgra
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Libreria El Buen Lector";
            string cli = "";
            string Telf = "";
            double total = 0;
            double subtotal = 0;
            int numero = 0;
            int cantidad;
            int calculo = 0;
            double descuento = 0;
            int pago = 0;
            double vuelto = 0;
            double impVenta = 0;

            Console.WriteLine("...........Libreria El Buen Lector.............");
            Console.Write("Digite su nombre: ");
            cli = Console.ReadLine();

            Console.Write("Digite su numero de telefono: ");
            Telf = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("===================================");
            Console.WriteLine("*_*   " + title + "   *_*");
            Console.WriteLine("Lista de Libros");
            Console.WriteLine("===================================");
            Console.WriteLine("1- El Señor de los Anillos. Las Dos Torres. (Fantasia)");
            Console.WriteLine("2- Alicia en el pais de las Maravillas. (Infantil)");
            Console.WriteLine("3- Sementerio de Mascotas. (Misterio)");
            Console.WriteLine("4- Quiero Aprender. (Educativo)");
            Console.WriteLine("5- El Poder del Pensamiento Positivo. (Superacion)");
            Console.WriteLine("6- El primer libro de matematicas. (Educativo)");
            Console.WriteLine("7- Las Aventuras de Tom Sawyer. (Infantil)");
            Console.WriteLine("8- El Mago de Oz. (Fantasia)");
            Console.WriteLine("9- La Zona Muerta. (Misterio)");
            Console.WriteLine("10- Viaje al Centro de la Tierra. (Ciencia Ficcion)");
            Console.WriteLine("");
            Console.WriteLine("//////////////////Precios//////////////////");
            Console.WriteLine("");
            Console.WriteLine("Categoria: Infantiles // Descuento: 5%  Precio: ¢2500");
            Console.WriteLine("Categoria: Misterio //   Descuento: 10% Precio: ¢3000");
            Console.WriteLine("Categoria: Fantasia //   Descuento: 15% Precio: ¢5000");
            Console.WriteLine("Categoria: Educativos // Descuento: 20% Precio: ¢7000");
            Console.WriteLine("Categoria: Otros //      Descuento: 25% Precio: ¢6000");

            Console.WriteLine("");
            Console.Write("Que libro desea comprar: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Cuantas unidades desea comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            if (numero == 2 || numero == 7)
            {
                calculo = cantidad * 2500;
                descuento = (calculo * 0.05);
                subtotal = calculo - descuento;
                impVenta = subtotal * 0.13;
                total = (calculo - descuento) + impVenta;
                Console.Write("El monto total a pagar es de: " + total);
                Console.WriteLine("");
                Console.Write("Con cuanto desea cancelar: ");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - total;

            }
            else if (numero == 3 || numero == 9)
            {
                calculo = cantidad * 3000;
                descuento = (calculo * 0.1);
                subtotal = calculo - descuento;
                impVenta = subtotal * 0.13;
                total = (calculo - descuento) + impVenta;
                Console.WriteLine("El monto total a pagar es de: " + total);
                Console.WriteLine("");
                Console.WriteLine("Con cuanto desea cancelar?: ");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - total;

            }
            else if (numero == 4 || numero == 6)
            {
                calculo = cantidad * 7000;
                descuento = (calculo * 0.2);
                subtotal = calculo - descuento;
                impVenta = subtotal * 0.13;
                total = (calculo - descuento) + impVenta;
                Console.Write("El monto total a pagar es de: " + total);
                Console.WriteLine("");
                Console.Write("Con cuanto desea cancelar?: ");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - total;

            }
            else if (numero == 1 || numero == 8)
            {
                calculo = cantidad * 5000;
                descuento = (calculo * 0.15);
                subtotal = calculo - descuento;
                impVenta = subtotal * 0.13;
                total = subtotal - impVenta;
                Console.Write("El monto total a pagar es de: " + total);
                Console.WriteLine("");
                Console.Write("Con cuanto desea cancelar?: ");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - total;

            }
            else
            {
                calculo = cantidad * 6000;
                descuento = (calculo * 0.25);
                subtotal = calculo - descuento;
                impVenta = subtotal * 0.13;
                total = (calculo - descuento) + impVenta;
                Console.Write("El monto total a pagar es de: " + total);
                Console.WriteLine("");
                Console.Write("Con cuanto desea cancelar?: ");
                pago = int.Parse(Console.ReadLine());
                vuelto = pago - total;

            }

            Console.WriteLine("");

            Console.WriteLine("===================================");
            Console.WriteLine("*_*   " + title + "   *_*");
            Console.WriteLine("===================================");
            Console.WriteLine("Factura Proforma               N001");
            Console.WriteLine("Cliente: " + cli);
            Console.WriteLine("Numero de Telefono: " + Telf);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Item-------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total Orden					" + calculo);
            Console.WriteLine("Descuento					" + descuento);
            Console.WriteLine("Impuesto Venta					 13%");
            Console.WriteLine("Impuesto Total				                " + impVenta);
            Console.WriteLine("Precio Neto					" + total);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Monto Recibido					            " + pago);
            Console.WriteLine("Monto Cambio						" + vuelto);
            Console.WriteLine("===================================");
            Console.WriteLine("Gracias por su compra...");
        }
    }
}