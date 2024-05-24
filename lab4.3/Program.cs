using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách các đối tượng student
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 15 },
            new Student { Name = "Bob", Age = 17 },
            new Student { Name = "Charlie", Age = 12 },
            new Student { Name = "David", Age = 20 },
            new Student { Name = "Eve", Age = 18 }
        };

        // a/ Xuất ra màn hình các student có Age > 12 và Age < 20 bằng cách dùng LINQ Query Syntax
        var queryResult = from student in students
                          where student.Age > 12 && student.Age < 20
                          select student;

        Console.WriteLine("Students with Age > 12 and Age < 20 (Query Syntax):");
        foreach (var student in queryResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // b/ Xuất ra màn hình các student có Age > 12 và Age < 20 bằng cách dùng LINQ Method Syntax
        var methodResult = students.Where(student => student.Age > 12 && student.Age < 20);

        Console.WriteLine("\nStudents with Age > 12 and Age < 20 (Method Syntax):");
        foreach (var student in methodResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}