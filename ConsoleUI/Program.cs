using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            // {
            //    Console.WriteLine("Car Id: "+ car.CarId);
            //    Console.WriteLine("Brand Id: "+ car.BrandId);
            //    Console.WriteLine("Model Year: "+ car.ModelYear);
            //    Console.WriteLine("Price: "+ car.DailyPrice);
            //    Console.WriteLine("Description: "+ car.Description);
            //}
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.CarId);

            //}
            //foreach (var car in carManager.GetByDailyPrice(100,500))
            //{
            //    Console.WriteLine(car.CarId);
            //}
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.CarId);
            }



        }
    }
}
