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
    public class HotelManager : IHotelService
    {

        private IHotelRepository _hotelRepository;

        public HotelManager()
        {
            _hotelRepository = new HotelRepository();

        }


        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);  
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if (id>0)
            {
            return _hotelRepository.GetHotelsById(id);  
            }
            throw new Exception("Id Con not be less than 0");

        }

        public Hotel UpdateHotel(Hotel hotel)
        {  
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
