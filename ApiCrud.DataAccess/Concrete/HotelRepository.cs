using ApiCrud.DataAccess.Abstract;
using ApiCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        private HotelDbContext _context;
        public HotelRepository(HotelDbContext dbContext)
        {
            _context = dbContext;
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return hotel;
        }

        public void DeleteHotel(int id)
        {
            var deleteHotel = GetHotelsById(id);
            _context.Hotels.Remove(deleteHotel);
            _context.SaveChanges();
        }

        public List<Hotel> GetAllHotels()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetHotelsById(int id)
        {
            return _context.Hotels.Find(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
            return hotel;
        }
    }
}
