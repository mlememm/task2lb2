using System;
class Student
{
    public string Name { get; set; }
    public Student(string name)
    {
        Name = name;
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Ім'я студента: {Name}");
    }
}
class Program
{
    static void ChangeStudentName(Student student, string newName)
    {
        Console.WriteLine($"\nВсередині методу ChangeStudentName:");
        Console.WriteLine($"  Поточне ім'я (до зміни): {student.Name}");
        student.Name = newName;
        Console.WriteLine($"  Нове ім'я (після зміни): {student.Name}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Демонстрація класу Student та передачі об'єктів за посиланням.");
        Console.WriteLine("---------------------------------------------------------------");
        Console.Write("Початкове ім'я студента: ");
        string initialName = Console.ReadLine();
        Console.WriteLine("\nВводимо ім'я студента до списку:");
        Student student1 = new Student(initialName);
        student1.DisplayStudentInfo();
        Console.Write("\nВведіть нове ім'я для студента: ");
        string newName = Console.ReadLine();
        Console.WriteLine("\nВикликаємо метод зміни імені...");
        ChangeStudentName(student1, newName);
        Console.WriteLine("\nПісля виклику методу зміни імені:");
        student1.DisplayStudentInfo();
        Console.WriteLine("---------------------------------------------------------------");
    }
}