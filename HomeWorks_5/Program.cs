﻿//Задача 36: Задайте одномерный массив, заполненный случайными
//числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19  / [-4, -6, 89, 6] -> 0


// Console.Write("Imput the size of the array:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);

// // Console.WriteLine("массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 1; z < numbers.Length; z += 2)
//     sum = sum + numbers[z];

// Console.WriteLine($"Array of {numbers.Length} numbers; Sum of elements in odd positions -> {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(-20, 20);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Imput the size of the array:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);

// PrintArray(numbers);
// int evenNambers = 0;

// for (int z = 0; z < numbers.Length; z++)
//     if (numbers[z] % 2 == 0)
//         evenNambers++;

// Console.WriteLine($"Array of {numbers.Length} numbers; even numbers => {evenNambers}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 1001);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76


// Console.Write("Imput the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);

// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//     {
//         max = numbers[z];
//     }
//     if (numbers[z] < min)
//     {
//         min = numbers[z];
//     }
// }

// Console.WriteLine($"Max number => {max} , Min number => {min}");
// Console.WriteLine($"Difference between max and min numbers -> {Math.Round(max - min, 2)}");
// void FillArrayRandomNumbers(double[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = Convert.ToDouble(new Random().Next(10, 1000)) / 100;
//     }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
