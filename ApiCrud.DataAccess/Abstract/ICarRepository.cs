using ApiCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.DataAccess.Abstract
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
        Car GetCarsById(int id);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
