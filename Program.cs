using System;

namespace Raiz_y_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos
            double num, pot, resultado, resultado1;

            try{
                //Introduccion del numero
                Console.WriteLine("Digite un número: ");
                num = Convert.ToDouble(Console.ReadLine());
                //Asignacion de valor a la variable pot
                pot = 2;
                //Resultados calculados
                resultado = Math.Pow(num, pot);
                resultado1 = Math.Sqrt(num);
                //If que verifica si el numero es 0 o menor que 0
                if (num > 0){
                    Console.WriteLine($"Del número: {num}, su potencia es {resultado} y su raíz es {resultado1} ");
                }
                else
                {
                    Console.WriteLine("El número que introdujo es 0 o menor que 0");
                }
                }catch(Exception error){
                    Console.WriteLine(error.Message);
                }
            Console.ReadKey();
        } 
    }
}
