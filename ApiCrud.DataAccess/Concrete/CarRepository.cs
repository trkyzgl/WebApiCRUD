using ApiCrud.DataAccess.Abstract;
using ApiCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.DataAccess.Concrete
{
    public class CarRepository: ICarRepository
    {
        private HotelDbContext _context;
        public CarRepository(HotelDbContext dbContext)
        {
            _context = dbContext;
        }

        public Car CreateCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public void DeleteCar(int id)
        {
            var deleteCar = GetCarsById(id);
            _context.Cars.Remove(deleteCar);
            _context.SaveChanges();
        }

        public List<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public Car GetCarsById(int id)
        {
            return _context.Cars.Find(id);
        }

        public Car UpdateCar(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
            return car;
        }
    }
}
