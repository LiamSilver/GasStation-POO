using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Models
{
    public class Sale
    {
        Sale(Client client, FuelPump pump)
        { 
            setClient(client);
            setPump(pump);
            setLiterPrice(pump);
        }

        public Client client { get; private set; }
        public FuelPump pump { get; private set; }
        public decimal literPrice { get; private set; }
        public double liter { get; set; }

        public void setLiterPrice(FuelPump pump)
        {
            this.literPrice = pump.typeFuel.fuelPrice;
        }

        public void setClient(Client client)
        {
            this.client= client;
        }

        public void setPump(FuelPump pump)
        {
            this.pump = pump;
        }

        public decimal getAmount()
        {
            return (decimal)(Convert.ToDouble(literPrice) * liter);
        }


    }
}
