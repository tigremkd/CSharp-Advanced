// See https://aka.ms/new-console-template for more information

using SEDC.Oop.Class04.Generics.Entities;

GenericMethods gMethods = new GenericMethods();

//gMethods.PrintObject("Something");
//gMethods.PrintObject<DateTime>(DateTime.Now);
//gMethods.PrintObject<int>(34);


NonGenericHelper helper = new NonGenericHelper();

List<string> stringList = new List<string>() { "Hello", "World", "Generic", "Methods" };

helper.GoTroughStringList(stringList);
helper.GetInfoForList(stringList);


Console.ReadLine();

Console.WriteLine(helper.ToString());
