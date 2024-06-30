using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстового поля та розбиваємо на окремі елементи масиву
            double[] array = textBox1.Text.Split(' ').Select(double.Parse).ToArray();

            // а) мінімальний за модулем елемент масиву
            double minAbsValue = array.Min(Math.Abs);
            MessageBox.Show($"Мінімальне за модулем значення: {minAbsValue}\r\n");

            // б) сума модулів елементів масиву, розташованих після першого елемента, рівного нулю
            int indexOfZero = Array.IndexOf(array, 0);
            if (indexOfZero != -1 && indexOfZero < array.Length - 1)
            {
                double sumAfterZero = array.Skip(indexOfZero + 1).Sum(Math.Abs);
                MessageBox.Show($"Сума модулів після першого нуля: {sumAfterZero}");
            }
            else
            {
                MessageBox.Show("У масиві немає нульових елементів або всі вони є останніми.");
            }

            // Перетворення масиву
            double[] transformedArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                transformedArray[i] = i % 2 == 0 ? array[i] : array[array.Length - 1 - i];
            }

            // Виведення перетвореного масиву
            MessageBox.Show($"Перетворений масив: {string.Join(" ", transformedArray)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстового поля та розбиваємо на окремі рядки масиву
            double[][] array = textBox2.Text
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(row => row.Split(' ').Select(double.Parse).ToArray())
                .ToArray();

            // а) розрахунок суми двох будь-яких елементів третього стовбця масиву
            double sumColumn3 = array.Select(row => row.Length > 2 ? row[2] : 0).Sum();
            MessageBox.Show($"Сума елементів третього стовбця: {sumColumn3}\r\n");

            // б) розрахунок добутку двох будь-яких елементів другого рядка масиву
            int rowToMultiply = 1; // враховуючи 0-індексацію
            if (rowToMultiply < array.Length)
            {
                double productRow2 = array[rowToMultiply].Aggregate(1.0, (acc, val) => acc * val);
                MessageBox.Show($"Добуток елементів другого рядка: {productRow2}");
            }
            else
            {
                MessageBox.Show($"Вказаний рядок виходить за межі масиву.");
            }
        }

    }
}
