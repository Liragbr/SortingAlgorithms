using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetMergeSort = { 38, 27, 43, 3, 9, 82, 10 };
        int[] vetBubbleSort = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Vetor original para Merge Sort:");
        PrintArray(vetMergeSort);

        MergeSort(vetMergeSort);

        Console.WriteLine("Vetor ordenado com Merge Sort:");
        PrintArray(vetMergeSort);

        Console.WriteLine("Vetor original para Bubble Sort:");
        PrintArray(vetBubbleSort);

        BubbleSort(vetBubbleSort);

        Console.WriteLine("Vetor ordenado com Bubble Sort:");
        PrintArray(vetBubbleSort);
    }

    static void MergeSort(int[] vet)
    {
        if (vet.Length <= 1)
        {
            return;
        }

        int tam1 = vet.Length / 2;
        int tam2 = vet.Length - tam1;
        int[] v1 = new int[tam1];
        int[] v2 = new int[tam2];

        for (int i = 0; i < tam1; i++)
        {
            v1[i] = vet[i];
        }
        for (int i = 0; i < tam2; i++)
        {
            v2[i] = vet[i + tam1];
        }

        MergeSort(v1);
        MergeSort(v2);

        int ind1 = 0, ind2 = 0, ind3 = 0;
        while (ind1 < tam1 && ind2 < tam2)
        {
            if (v1[ind1] < v2[ind2])
            {
                vet[ind3] = v1[ind1];
                ind1++;
            }
            else
            {
                vet[ind3] = v2[ind2];
                ind2++;
            }
            ind3++;
        }

        while (ind1 < tam1)
        {
            vet[ind3] = v1[ind1];
            ind1++;
            ind3++;
        }

        while (ind2 < tam2)
        {
            vet[ind3] = v2[ind2];
            ind2++;
            ind3++;
        }
    }

    static void BubbleSort(int[] vet)
    {
        int n = vet.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (vet[j] > vet[j + 1])
                {
                    int temp = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] vet)
    {
        foreach (int value in vet)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
