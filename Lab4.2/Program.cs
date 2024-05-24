using System;
using System.Collections.Generic;
using System.Linq;

class userData
{
    public string Name { get; set; }
    public int Level { get; set; }
}

class Program
{
    static void Main()
    {
        List<userData> users = new List<userData>
        {
            new userData { Name = "Alice", Level = 5 },
            new userData { Name = "Bob", Level = 3 },
            new userData { Name = "Charlie", Level = 7 }
        };

        // a/ Xuất thông tin "Name" và "Level" của danh sách "userData"
        Console.WriteLine("Thông tin Name và Level của danh sách:");
        users.Select(u => new { u.Name, u.Level }).ToList().ForEach(u => Console.WriteLine($"Name: {u.Name}, Level: {u.Level}"));

        // b/ Thêm một đối tượng userData mới vào danh sách và hiển thị thông tin
        users.Add(new userData { Name = "David", Level = 2 });
        Console.WriteLine("\nDanh sách sau khi thêm đối tượng mới:");
        users.Select(u => new { u.Name, u.Level }).ToList().ForEach(u => Console.WriteLine($"Name: {u.Name}, Level: {u.Level}"));
    }
}