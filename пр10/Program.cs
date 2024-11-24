using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
        //Console.WriteLine("Обнуление элементов массива");
        //int[] array1 = { 10, 20, 30, 40, 50, 60, 70, 80 }; 
        //Console.WriteLine("Исходный массив: " + string.Join(" ", array1));
        //for (int i = 1; i <= 3; i++) array1[i] = 0; 
        //Console.WriteLine("Массив после обнуления: " + string.Join(" ", array1));

        // Задача 2
        //Console.WriteLine("\nИзменение размера массива");
        //int[] array2 = { 1, 2, 3, 4, 5 }; 
        //Console.WriteLine("Исходный массив: " + string.Join(" ", array2));
        //Array.Resize(ref array2, 7); 
        //array2[5] = 6;
        //array2[6] = 7; 
        //Console.WriteLine("Измененный массив: " + string.Join(" ", array2));

        // Задача 3
        Console.WriteLine("\nИндекс первого отрицательного элемента");
        int[] array3 = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < array3.Length; i++) array3[i] = rnd.Next(-5, 6); 
        Console.WriteLine("Массив: " + string.Join(" ", array3));
        int index = Array.FindIndex(array3, x => x < 0); 
        Console.WriteLine(index != -1 ? $"Индекс первого отрицательного элемента: {index}" : "Отрицательных элементов нет");
            Console.Read();        
        }
    }
}
