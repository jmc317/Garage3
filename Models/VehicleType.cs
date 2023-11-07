using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Garage3.Models
{
    public enum VehicleType
    {
        Car,
        Motorcycle,
        Bus,
        Truck
    }

    public class VehicleViewModel
    {
        public VehicleType SelectedVehicleType { get; set; }
    }
}
