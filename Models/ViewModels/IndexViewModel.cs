using Humanizer.Localisation;

namespace Garage3.Models.ViewModels
{

        public class IndexViewModel
        {
            public IEnumerable<ParkedVehicle> Garage { get; set; } = new List<ParkedVehicle>();
            public FilterParams FilterParams { get; set; } = new FilterParams();

        }

        public class FilterParams
        {
            public string? Title { get; set; }
            public VehicleType? VehicleType { get; set; }

        }
    }

