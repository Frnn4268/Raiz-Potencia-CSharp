using System;

namespace Raiz_y_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos
            double num, pot, resultado, resultado1;
            //Introduccion del numero
            Console.WriteLine("Digite un número: ");
            num = Convert.ToDouble(Console.ReadLine());
            //Cambio de valor de pot a num
            pot = num;
            //Resultados calculados
            resultado = Math.Pow(num, pot);
            resultado1 = Math.Sqrt(num);
            //Reslutados escritos por medio de if
            if (num > 0){
                Console.WriteLine($"Del número: {num}, su potencia es {resultado} y su raíz es {resultado1} ");
            }
            else
            {
                Console.WriteLine("El número que introdujo es 0 o menor que 0");
            }
            Console.ReadLine();
        } 
    }
}
