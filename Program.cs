using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numCombitwiseAdireita, numCombitwiseAesquerda;
            num = 10;
            numCombitwiseAdireita = num >> 1;
            numCombitwiseAesquerda = num << 1;
            Console.WriteLine("Valor antes: "+num+", valor de num com o bitwise a direita "+numCombitwiseAdireita);
            Console.WriteLine("Valor antes: "+num+", valor de num com o bitwise a esquerda "+numCombitwiseAesquerda);
            
        }
    }
}