
namespace GasStation.Models
{
    public class Fuel
    {
        public int CodCombustivel { get; private set; }
        public string descFuel { get; private set; }
        
        public decimal fuelPrice { get; private set;}

        public void setDesc(string desc)
        {
            descFuel = desc;
        }

        public void setFuelPrice(decimal fuelPrice)
        {
            this.fuelPrice = fuelPrice;
        }

        public void setCod(int codCombustivel)
        {
            CodCombustivel= codCombustivel;
        }
    }
}
