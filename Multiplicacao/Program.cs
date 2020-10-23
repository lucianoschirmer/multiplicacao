using System;

namespace Multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            byte[] array1 = new byte[3];
            byte[] array2 = new byte[3];

            //byte[] array4 = new byte[5];
            
            random.NextBytes(array1);
            random.NextBytes(array2);

            //random.NextBytes(array4);

            Console.WriteLine(string.Join(", ", array1));            
            Console.WriteLine(string.Join(", ", array2));
            

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("array3: " + array1[i] * array2[i]  + ", ");
            }

            //for (int i = 0; i < array4.Length; i++)
            //{
            //    Console.Write(array4[i]);
            //}
            //Console.WriteLine("##############");
            //Console.WriteLine(string.Join(", ", array4));

            ////////////////////////////////////////////////////////////

            Console.WriteLine("Números Pares e Ímpares!");
            Console.WriteLine("--------------------------------");

            //Random random = new Random();
            //byte[] values = new byte[10];
            //random.NextBytes(values);
            //Console.WriteLine(string.Join(", ", values));

            int npar = 0;
            int nimpar = 0;

            int cont = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    npar++;
                }
            }
            nimpar = values.Length - npar;

            //if (int j = 0; j < values.Length; j++)
            //{

            //}

            Console.WriteLine("--------------------------------");
            Console.WriteLine(npar + " Números pares");
            Console.WriteLine(nimpar + " Números ímpares");
            Console.WriteLine("--------------------------------");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
