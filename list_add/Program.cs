using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_add
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание списка numbers c значениями { 1, 2, 3, 4, 5 }
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Вывод строки "Исходный список:" на консоль.
            // Затем вызов функции PrintList для печати содержимого списка numbers.
            Console.WriteLine("Исходный список:");
            PrintList(numbers);

            // Вызов функции AddValueToList для добавления нового значения в список numbers
            numbers = AddValueToList(numbers, 6);

            // Вывод Список numbers после добавления нового значения
            // Затем вызов функции PrintList для печати списка numbers после добавления нового значения.
            Console.WriteLine("\nСписок после добавления нового значения:");
            PrintList(numbers);

            Console.ReadLine();
        }

        // Объявление функции AddValueToList, которая принимает список list типа List<int> и
        // значение newValue типа int в качестве аргументов и возвращает список List<int>.
        static List<int> AddValueToList(List<int> list, int newValue)
        {
            // Добавление нового значения newValue в конец списка list с помощью метода Add().
            // Функция возвращает измененный список.
            list.Add(newValue);
            return list;

        }

        // Объявление функции PrintList, которая принимает список list типа List<int> в качестве аргумента и не возвращает ничего.
        static void PrintList(List<int> list)
        {
            // вывод содержимого списка list на консоль с использованием цикла foreach,
            // который перебирает каждый элемент списка и выводит его на консоль, разделяя пробелом.
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
