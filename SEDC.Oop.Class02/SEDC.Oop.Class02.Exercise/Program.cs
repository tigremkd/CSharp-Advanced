// See https://aka.ms/new-console-template for more information

using SEDC.Oop.Class02.Exercise;
using SEDC.Oop.Class02.Exercise.Interfaces;

User teacher1 = new Teacher()
{
    Id = 1,
    Name = "Trajan",
    Password = "password1",
    UserName = "Trajan4e",
    Subject = "C# basic"
};

User teacher2 = new Teacher()
{
    Id=2,
    Name = "Igor",
    UserName = "Tigre",
    Password = "pw123",
    Subject = "C# Advanced"

};

User student1 = new Student()
{
    Id = 3,
    Name = "Sara",
    UserName = "Sar4e",
    Password = "12345",
    Grades = 7
};
User student2 = new Student()
{
    Id = 3,
    Name = "Ana",
    UserName = "konanchi",
    Password = "5543321",
    Grades = 8
};

teacher1.PrintUser();
teacher2.PrintUser();
student1.PrintUser();
student2.PrintUser();

IUser teacher11 = new Teacher()
{
    Id = 1,
    Name = "Trajan",
    Password = "password1",
    UserName = "Trajan4e",
    Subject = "C# basic"
};

IUser teacher22 = new Teacher()
{
    Id = 2,
    Name = "Igor",
    UserName = "Tigre",
    Password = "pw123",
    Subject = "C# Advanced"

};

IUser student11 = new Student()
{
    Id = 3,
    Name = "Sara",
    UserName = "Sar4e",
    Password = "12345",
    Grades = 7
};
IUser student22 = new Student()
{
    Id = 3,
    Name = "Ana",
    UserName = "konanchi",
    Password = "5543321",
    Grades = 8
};

teacher11.PrintUser();
teacher22.PrintUser();
student11.PrintUser();
student22.PrintUser();















Console.ReadLine();
