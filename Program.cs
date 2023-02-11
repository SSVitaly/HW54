void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}

int rows = 5;
int coloms = 5;
int[,] Array = new int[rows, coloms];
FillArray(Array);
PrintArray(Array);

Console.WriteLine();

int temp;

for (int k = 0; k < Array.GetLength(0); k++)
{
    for (int i = 0; i < Array.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < Array.GetLength(1); j++)
        {
            if (Array[k, i] < Array[k, j])
            {
                temp = Array[k, i];
                Array[k, i] = Array[k, j];
                Array[k, j] = temp;
            }
        }
    }
}


PrintArray(Array);