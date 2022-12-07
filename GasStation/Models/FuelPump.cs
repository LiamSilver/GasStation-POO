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

        #region attributes

        private int? _codPump;
        private decimal _pumpCapacity;
        private decimal _fuelAvailable;
        private Fuel _typeFuel;
        private string _namePump;

        #endregion

        #region properties
        public int? codPump { get { return _codPump; } private set { if(value!=null) _codPump = (int)value; } }
        public decimal pumpCapacity{ get { return _pumpCapacity; } private set { _pumpCapacity = value; } }

        public decimal fuelAvailable { get { return _fuelAvailable; } private set { _fuelAvailable = value; } }

        public Fuel typeFuel { get { return _typeFuel; } private set { _typeFuel = value; } }
        public string namePump { get { return _namePump; } private set { _namePump = value; } }

        #endregion

        #region constructors

        public FuelPump()
        {

        }

        public FuelPump(int? codPump, decimal pumpCapacity, decimal fuelAvailable, Fuel typeFuel, string? namePump)
        {
            this.codPump = codPump;
            this.pumpCapacity = pumpCapacity;
            this.fuelAvailable = fuelAvailable;
            this.typeFuel = typeFuel;
            this.namePump = namePump;
        }

        #endregion

    }
}
