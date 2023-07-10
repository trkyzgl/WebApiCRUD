using ApiCrud.Business.Abstract;
using ApiCrud.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet("carlist")]
        public List<Car> Get()
        {
            return _carService.GetAllCars();
        }


        [HttpPost]
        public Car Post(Car car)
        {
            return _carService.CreateCar(car);
        }


        [HttpPut]
        public Car Put(Car car)
        {
            return _carService.UpdateCar(car);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carService.DeleteCar(id);
        }

    }
}
