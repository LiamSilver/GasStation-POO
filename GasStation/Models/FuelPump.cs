using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Models
{
     public class FuelPump
    {
        private int? codPump { get; set; }
        public decimal pumpCapacity{ get; private set; }

        public decimal fuelAvailable { get; private set; }

        public Fuel typeFuel { get; private set; }
        public string descPump { get; private set; }


        public void setCapacity(decimal Capacity)
        {
            pumpCapacity = Capacity;
        }

        public void setFuelAvailable(decimal FuelAvailable)
        {
            this.fuelAvailable = FuelAvailable;
        }

        public void setTypeFuel(Fuel fuel)
        {
            typeFuel= fuel;
        }
        public void setDescPump(string descPump)
        {
            this.descPump = descPump;
        }

        public void setCodPump(int cod)
        {
            this.codPump = cod;
        }

        public int getCodPump()
        {
            if (codPump != null)
                return (int)codPump;
            else
                throw new Exception("Ocorreu um erro");
        }
    }
}
