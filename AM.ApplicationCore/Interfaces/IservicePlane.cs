using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IservicePlane: IService<Plane>
    { 
        IEnumerable<Traveller> Getpassenger(Plane plane);
        IEnumerable<Flight> Getflights(int n);
        bool reserver( Flight flight,int n);
        void DeletePlane();
        
    }
}
