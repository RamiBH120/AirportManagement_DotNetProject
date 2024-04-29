using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight: IService<Flight>
    {
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
        IEnumerable<Traveller> SeniorTravellers(Flight f);
        
            double DurationAverage(string destination);
        int ProgrammedFlightNumber(DateTime startDate);
        IEnumerable<Staff> getstaffs(int volID);
        IEnumerable<Traveller> GetTravellers(Plane plane, DateTime DateVol);

        public IEnumerable<Flight> SortFlights();
    }
}
