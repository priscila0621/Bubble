using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble.Models
{
    public class Sorter
    {
        // Método que implementa el algoritmo de ordenamiento burbuja
        public void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            bool swapped;
            // Bucle para recorrer el arreglo
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                // Comparar elementos adyacentes
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Si el elemento actual es mayor que el siguiente, intercambiarlos
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }
                // Si no se hicieron intercambios, el arreglo ya está ordenado
                if (!swapped) break;
            }
        }
    }
}
