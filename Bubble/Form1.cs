using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bubble.Models;

namespace Bubble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Obtener la cadena de números desde el TextBox
            string input = tbNumbers.Text;

            // Separar los números en un arreglo
            int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

            // Crear un objeto de la clase Sorter
            Sorter sorter = new Sorter();

            // Ordenar los números usando bubble sort
            sorter.BubbleSort(numbers);

            // Mostrar los números ordenados en el ListBox
            lbSortedNumbers.Items.Clear();
            foreach (var num in numbers)
            {
                lbSortedNumbers.Items.Add(num);
            }
        }
    }
    
}
