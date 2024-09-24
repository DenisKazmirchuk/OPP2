using System;

// Abstract base class Document
abstract class Document
{
    public string Title { get; set; }

    // Constructor with parameter
    public Document(string title)
    {
        Title = title;
    }

    // Abstract methods to be overridden by derived classes
    public abstract void ShowDocumentInfo();
    public abstract void ShowTitle();
}

// Derived class CourseWork
class CourseWork : Document
{
    public string Student { get; set; }
    public string Discipline { get; set; }
    public int Grade { get; set; }

    // Constructor with parameters
    public CourseWork(string title, string student, string discipline, int grade)
        : base(title)
    {
        Student = student;
        Discipline = discipline;
        Grade = grade;
    }

    // Overriding abstract methods from Document
    public override void ShowDocumentInfo()
    {
        Console.WriteLine($"Курсова робота: {Title}, Студент: {Student}, Дисципліна: {Discipline}, Оцінка: {Grade}");
    }

    public override void ShowTitle()
    {
        Console.WriteLine($"Заголовок: {Title}, Оцінка: {Grade}");
    }

    // Method to check student and set new grade
    public void UpdateGrade(string student, int newGrade)
    {
        if (Student == student)
        {
            Grade = newGrade;
            ShowDocumentInfo();
        }
        else
        {
            Console.WriteLine("Студента не знайдено.");
        }
    }

    // Method to show title and grade
    public void ShowTitleAndGrade()
    {
        Console.WriteLine($"Заголовок: {Title}, Оцінка: {Grade}");
    }
}

// Derived class Diploma
class Diploma : Document
{
    public string Student { get; set; }
    public int DefenseYear { get; set; }
    public string Supervisor { get; set; }

    // Constructor with parameters
    public Diploma(string title, string student, int defenseYear, string supervisor)
        : base(title)
    {
        Student = student;
        DefenseYear = defenseYear;
        Supervisor = supervisor;
    }

    // Overriding abstract methods from Document
    public override void ShowDocumentInfo()
    {
        Console.WriteLine($"Диплом: {Title}, Студент: {Student}, Рік захисту: {DefenseYear}, Куратор: {Supervisor}");
    }

    public override void ShowTitle()
    {
        Console.WriteLine($"Заголовок: {Title}");
    }

    // Method to show info with parameters year and supervisor
    public void ShowInfo(int year, string supervisor)
    {
        if (DefenseYear == year && Supervisor == supervisor)
        {
            Console.WriteLine($"Диплом: {Title}, Студент: {Student}, Рік захисту: {DefenseYear}, Куратор: {Supervisor}");
        }
        else
        {
            Console.WriteLine("Не знайдено відповідного року захисту або керівника.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a CourseWork object
        CourseWork coursework = new CourseWork("Структури даних", "Іван", "Комп'ютерні науки", 85);
        coursework.ShowDocumentInfo();
        coursework.UpdateGrade("Іван", 90);
        coursework.ShowTitleAndGrade();

        // Creating a Diploma object
        Diploma diploma = new Diploma("Дослідження ШІ", "Денис", 2023, "Сергій Григорович Карпенко");
        diploma.ShowDocumentInfo();
        diploma.ShowInfo(2023, "Сергій Григорович Карпенко");
    }
}
