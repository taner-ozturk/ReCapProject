using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
             {
                Console.WriteLine("Car Id: "+ car.Id);
                Console.WriteLine("Brand Id: "+ car.BrandId);
                Console.WriteLine("Model Year: "+ car.ModelYear);
                Console.WriteLine("Price: "+ car.DailyPrice);
                Console.WriteLine("Description: "+ car.Description);
            }
          
        }
    }
}
