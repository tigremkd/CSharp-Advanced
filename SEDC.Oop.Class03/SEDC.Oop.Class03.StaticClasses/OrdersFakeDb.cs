using SEDC.Oop.Class03.StaticClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses
{
    public static class OrdersFakeDb
    {
        public static int orderId = 5;

        public static List<Order> Orders { get; set; }

        public static List<User> Users { get; set; }

        static OrdersFakeDb()
        {
            Orders = new List<Order>();
            Users = new List<User>();

            Orders.Add(new Order(1, "Order 1", "order 1 description ", OrderStatus.Shipped));
            Orders.Add(new Order(2, "Order 2", "order 2 description ", OrderStatus.Proccessing));
            Orders.Add(new Order(3, "Order 3", "order 3 description ", OrderStatus.Delivered));
            Orders.Add(new Order(4, "Order 4", "order 4 description ", OrderStatus.Delivered));
            Orders.Add(new Order(5, "Order 5", "order 5 description ", OrderStatus.Shipped));

            Users.Add(new User(1, "Igor", "Igorov"));
            Users.Add(new User(2, "Sara", "Sarova"));
            Users.Add(new User(3, "Ana", "Anova"));
            Users.Add(new User(4, "Dori", "Dorova"));
            Users.Add(new User(5, "Trpe", "Trpov"));

            //Users[0].Orders.Add(Orders[0]);
            //Users[1].Orders.Add(Orders[1]);
            //Users[1].Orders.Add(Orders[2]);
            //Users[0].Orders.Add(Orders[3]);


            Users.FirstOrDefault(user => user.Name == "Igor").Orders.Add(Orders.FirstOrDefault(order => order.Id == 1));
            Users.FirstOrDefault(user => user.Name == "Igor").Orders.Add(Orders.FirstOrDefault(order => order.Id == 2));
            Users.FirstOrDefault(user => user.Name == "Igor").Orders.Add(Orders.FirstOrDefault(order => order.Id == 3));
            Users.FirstOrDefault(user => user.Name == "Sara").Orders.Add(Orders.FirstOrDefault(order => order.Id == 4));
            Users.FirstOrDefault(user => user.Name == "Sara").Orders.Add(Orders.FirstOrDefault(order => order.Id == 5));

        }

        public static void AddOrder(string title, string description, OrderStatus status, User user)
        {
            orderId++;
            Order order = new Order { 
                Id = orderId,
                Title = title,
                Description = description,
                OrderStatus = status
            }; 
            
            Orders.Add(order);
            user.Orders.Add(order);

            
        }
    }
}
