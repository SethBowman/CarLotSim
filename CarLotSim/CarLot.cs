using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSim
{
    public class CarLot
    {
        public static int numberOfCars;
        public List<Car> Cars { get; set; }

        public CarLot()
        {
            Cars = new List<Car>();            
        }

        
    }
}
