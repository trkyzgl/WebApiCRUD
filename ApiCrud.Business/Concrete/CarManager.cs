using ApiCrud.Business.Abstract;
using ApiCrud.DataAccess.Abstract;
using ApiCrud.DataAccess.Concrete;
using ApiCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;

        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        public Car CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public Car CreateCar(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            if (id > 0)
            {
                return _carRepository.GetCarsById(id);
            }
            throw new Exception("Id Con not be less than 0");

        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }


    }
}
