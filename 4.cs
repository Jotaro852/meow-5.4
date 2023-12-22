using System;
using System.IO;
using System.Linq;
class work_5_4
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask4.txt"); // чтение данных из файла и запись в массив
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); // разделяем строку проблеами, перобразуем в числа, кладём в массив 
        int max = chosenUse.Max(); // минимальное
        int sum = 0; // cсумма

        for (int i = 0; i < chosenUse.Length; i++) // считаем всё, что посли минимального
        {
            if (chosenUse[i] == max - 1) // если число = max - 1
            {
                sum += chosenUse[i]; // складываем
            }
        }
        Console.WriteLine($"Произведение элементов после минимального числа: {sum}"); // вывод
    }
}