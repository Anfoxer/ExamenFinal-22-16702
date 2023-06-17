using System;

class program
{
    static void Main()
    {
        //Error :La matriz se está declarando como una matriz de 2 elementos, pero luego se intenta asignar valores a 6 elementos diferentes.
        int[,] Matriz = new int[3, 2];

        //intentamos asignar valores a los elementos de la matriz
        Matriz[0, 0] = 1;
        Matriz[0, 1] = 2;
        Matriz[1, 0] = 3;
        Matriz[1, 1] = 4;
        Matriz[2, 0] = 5;
        Matriz[2, 1] = 6;
        // intentamos inprimir los valores de la matriz

        //Error: El código intenta imprimir los valores de la matriz utilizando un bucle for, pero el índice i del bucle externo se está incrementando hasta 3 en lugar de 2.
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("elementos en la posicion [{0},{1}]: {2}", i, j, Matriz[i, j]);
            }
        }
        Console.ReadLine();
    }
}
