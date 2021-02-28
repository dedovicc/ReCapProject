using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{ Id=1, BrandId=3,ColorId = 1, DailyPrice=1500, ModelYear=2000,Description="Açıklama"},
                new Car{ Id=2, BrandId=1,ColorId = 2, DailyPrice=1500, ModelYear=1998,Description="Açıklama"},
                new Car{ Id=3, BrandId=2,ColorId = 2, DailyPrice=1500, ModelYear=1996,Description="Açıklama"},
                new Car{ Id=4, BrandId=3,ColorId = 3, DailyPrice=1500, ModelYear=2005,Description="Açıklama"},
                new Car{ Id=5, BrandId=3,ColorId = 4, DailyPrice=1500, ModelYear=2002,Description="Açıklama"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.ModelYear = car.ModelYear;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.Description = car.Description;
        }
    }
}
