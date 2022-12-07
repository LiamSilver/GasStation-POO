
namespace GasStation.Models
{
    public class Fuel
    {

        #region attributes

        private int _codCombustivel;
        private string _nameFuel;
        private decimal _fuelPrice;


        #endregion

        #region properties
        public int CodCombustivel { get { return _codCombustivel; } private set { _codCombustivel = value; } }
        public string nameFuel { get { return _nameFuel; } private set { _nameFuel = value; } }


        public decimal FuelPrice { get { return _fuelPrice; } private set { _fuelPrice = value; } }

        #endregion

        #region constructors

        public Fuel(long cod, string name, decimal price)
        {
            CodCombustivel = (int)cod;
            nameFuel = name;
            FuelPrice = price;
        }

        public Fuel(int cod, decimal price, string name)
        {
            CodCombustivel = cod;
            nameFuel = name;
            FuelPrice = price;

        }
        public Fuel()
        {

        }
        #endregion

    }
}
