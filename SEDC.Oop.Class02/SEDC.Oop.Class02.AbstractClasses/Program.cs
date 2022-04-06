// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class02.Entities;




Person employee = new Employee(1, "Igor", "Nikoloski", 40);
Person admin = new Admin(2, "Petko", "Petkov", "HR");

Console.WriteLine(employee.GetInfo());
Console.WriteLine(admin.GetInfo());


Figura krug = new Krug(5);
Figura kvadrat = new Kvadrat(5);

Console.WriteLine(krug.PresmetajPloshtina());
Console.WriteLine(kvadrat.PresmetajPloshtina());