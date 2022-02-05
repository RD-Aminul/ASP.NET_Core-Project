using ASP.NET_Core_Project.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Project.Data;

namespace ASP.NET_Core_Project.Models
{
    public class PassengerSQLRepository : IPassengerRepository
    {
        private readonly ApplicationDbContext _context;
        public PassengerSQLRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Passsenger> GetAllPassenger()
        {
            var classs = _context.Passengers.Include(c => c.Class).Include(r => r.Route).Include(t => t.Train).ToList();
            return classs;
        }

        public Passsenger DeletePassenger(int id)
        {
            Passsenger psngr = GetPassengerById(id);
            if (psngr != null)
            {
                _context.Passengers.Remove(psngr);
                _context.SaveChanges();
            }
            return psngr;
        }

        public bool GetPassengerByEmail(string email)
        {
            Passsenger psngr = _context.Passengers.Where(p => p.PassengerEmail == email).FirstOrDefault();
            if (psngr != null)
            {
                return true;
            }
            return false;
        }

        public Passsenger GetPassengerById(int id)
        {
            Passsenger psngr = _context.Passengers.Find(id);
            return psngr;
        }

        public Passsenger SavePassenger(Passsenger obj)
        {
            _context.Passengers.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Passsenger UpdatePassenger(Passsenger upobj)
        {
            var emp = _context.Passengers.Attach(upobj);
            emp.State = EntityState.Modified;
            _context.SaveChanges();
            return upobj;
        }
        public Train SaveTrain(Train obj)
        {
            _context.Trains.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Route SaveRoute(Route obj)
        {
            _context.Routes.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Class SaveClass(Class obj)
        {
            _context.Classes.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<Train> GetAllTrain()
        {
            return _context.Trains;
        }

        public IEnumerable<Route> GetAllRoute()
        {
            return _context.Routes;
        }

        public IEnumerable<Class> GetAllClass()
        {
            return _context.Classes;
        }
    }
}
