// See https://aka.ms/new-console-template for more information


using SEDC.Oop.Class03.StaticClasses;
using SEDC.Oop.Class03.StaticClasses.Entities;
using SEDC.Oop.Class03.StaticClasses.Utils;





//Console.WriteLine(FirstStaticClass.Counter);

//FirstStaticClass.Counter++;
//Console.WriteLine(FirstStaticClass.Counter);

//Console.WriteLine(FirstStaticClass.AddTwoNumbers(10,50));

//Console.WriteLine($"number of created users: {User.UserCount}");
//User user = new User(24, "Igor", "Nikoloski");
//Console.WriteLine($"number of created users: {User.UserCount}");
//User user2 = new User(30, "Sara", "Saki");
//Console.WriteLine($"number of created users: {User.UserCount}");
//User user3 = new User(27, "Trpe", "Trpeski");
//Console.WriteLine($"number of created users: {User.UserCount}");
//User user4 = new User(70, "Bob", "Bobski");


//user.PrintInfo();
//User.PrintUserCount();
//user2.PrintInfo();
//User.PrintUserCount();
//user3.PrintInfo();
//User.PrintUserCount();
//user4.PrintInfo();
//User.PrintUserCount();

//Console.WriteLine(StringUtils.CapitaliseFirstLetter("tigremkd"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("a"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("1234Asdf"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter(""));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter(null));


//Console.WriteLine(StringUtils.VerifyStringNumber("50"));
//Console.WriteLine(StringUtils.VerifyStringNumber(null));
//Console.WriteLine(StringUtils.VerifyStringNumber("asdf"));




foreach(User user in OrdersFakeDb.Users)
{
    user.PrintOrders();
}
User ana = OrdersFakeDb.Users.FirstOrDefault(user => user.Name == "Ana");

OrdersFakeDb.AddOrder("New Order", "new order description", OrderStatus.Proccessing, ana);
foreach (Order order in OrdersFakeDb.Orders)
{
    order.Print();
}





Console.ReadLine(); 