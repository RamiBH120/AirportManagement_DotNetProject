using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IservicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void DeletePlane()
        {
            Delete(p=>p.ManufactureDate.Year - DateTime.Now.Year > 10);


        }

        public IEnumerable<Flight> Getflights(int n)
        { 
            return GetAll().SelectMany(p=>p.Flights)
                .OrderByDescending(p=>p.FlightDate).Take(n);
        }

        public IEnumerable<Traveller> Getpassenger(Plane plane)
        {
            return plane.Flights
                .SelectMany(p => p.Passengers.OfType<Traveller>());
                
        }

        

        public bool reserver(Flight flight, int n)
        {
            return flight.Plane.Capacity >= flight.Passengers.Count() + n;
        }
    }
}
