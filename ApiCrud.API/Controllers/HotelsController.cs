﻿using ApiCrud.Business.Abstract;
using ApiCrud.Business.Concrete;
using ApiCrud.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("hotellist")]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }
        [HttpGet("getHotelById/{id}")]
        public Hotel GetHotelById(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost]
        public Hotel Post(Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }


        [HttpPut]
        public Hotel Put(Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _hotelService.DeleteHotel(id);
        }
    }
}
