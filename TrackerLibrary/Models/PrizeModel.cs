namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents an unique id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the numerical postion of the place
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents a custom name for the Place Number
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of the prize money
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the price money
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}