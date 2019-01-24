using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int sizeArray;
            sizeArray = int.Parse(Console.ReadLine());

            ArraySquareValue array=new ArraySquareValue(sizeArray);

            Random random = new Random();

            int indexValue;
            Console.Write("Входные значения: ");
            for (int i = 0; i < sizeArray; i++)
            {
                indexValue= random.Next(1, 6);
                Console.Write(indexValue+ " ");
                array[i] = indexValue;

            }

            Console.WriteLine();
            Console.Write("Квадрат значений: ");

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
