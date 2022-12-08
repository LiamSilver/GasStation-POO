using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Models
{
    public class Sell
    {
        #region attributes
        private Client _client;
        private FuelPump _pump;
        private decimal _literPrice;
        private decimal _liter;
        #endregion

        #region constructors
        public Sell(Client client, FuelPump pump)
        { 
            this.client = client;
            this.pump= pump;
            this.literPrice = pump.typeFuel.FuelPrice;
        }
        #endregion

        #region properties
        public Client client { get { return _client; } private set { _client = value; } }
        public FuelPump pump { get { return _pump; } private set { _pump = value; } }
        public decimal literPrice { get { return _literPrice; } private set { _literPrice = value; } }
        public decimal liter { get { return _liter; } set { _liter = value; } }

        public decimal Amount { get { return liter * literPrice; } }

        #endregion
    }
}
