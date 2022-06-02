using System;
using System.Collections.Generic;
using System.Linq;
namespace MyLinq
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3,0  };

            //var Query from ln in numbers
            //          orderby ln descending
            //          select ln;
            var Query = numbers.Where(n => n > 10)
                        .OrderByDescending(n => n);
            Console.WriteLine("Hello World!");
            List<Car> list = new List<Car>
            {
                new Car{Id=1, Name = "A" },
                new Car{Id=2, Name = "D"},
                new Car{Id=3, Name = "C"},
                new Car{Id =1, Name ="D"}
            };
            var Query1 = from cars in list
                         where cars.Id == 1
                         select cars;
            foreach (var car in Query1) Console.WriteLine(car.Name);
            var Query  = list.GroupBy(c => c.Name)   
                       .OrderBy(g => g.Key)
                       .Select(g => new {Key = g.Key, Count = g.Count)
        }
    }
}
