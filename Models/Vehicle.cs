using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage3.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }


        public string RegistrationNumber { get; set; }

       
        public string Color { get; set; }

        
        public string Brand { get; set; }

       
        public string Model { get; set; }

        // Double check before final submission if the int.MaxValue is good to keep
       
        public int NumberOfWheels { get; set; }

        public DateTime ArrivalTime { get; set; }
        public VehicleType VehicleType { get; internal set; }

        public ParkedVehicle() => ArrivalTime = DateTime.Now;
    }
}
