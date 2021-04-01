using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2020,DailyPrice=150,Description="İdeal araç."},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=220,Description="En yeni araç"},
                new Car{Id=3,BrandId=2,ColorId=5,ModelYear=2019,DailyPrice=110,Description="En uygun araç"}
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
