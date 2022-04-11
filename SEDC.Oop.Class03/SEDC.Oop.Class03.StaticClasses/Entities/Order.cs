using SEDC.Oop.Class03.StaticClasses.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            OrderStatus = status;
        }

        public void Print()
        {
            Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Title)} - { StringUtils.CapitaliseFirstLetter(Description)} ID: {Id}");
        }
        public Order()
        {

        }
    }
    public enum OrderStatus
    {
        Proccessing,
        Shipped,
        Delivered
    }
    
}
