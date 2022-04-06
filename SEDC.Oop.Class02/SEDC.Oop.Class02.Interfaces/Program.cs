// See https://aka.ms/new-console-template for more information


using SEDC.Oop.Class02.Entities;
using SEDC.Oop.Class02.Entities.Interfaces;

IUser user = new User(4);


Console.WriteLine(user.GetID());

IThingsThatCanWriteANote pen = new Pen();
IThingsThatCanWriteANote computer = new Computer();
IThingsThatCanWriteANote phone = new Phone();

pen.WriteNote();
computer.WriteNote();
phone.WriteNote();












Console.ReadLine();
