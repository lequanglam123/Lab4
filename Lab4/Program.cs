using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng Lambda Expression và FindAll để lọc các số chẵn
        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

        // Sử dụng foreach để xuất ra từng số chẵn trong list mới
        Console.WriteLine("Cac so chan trong danh sach la:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}