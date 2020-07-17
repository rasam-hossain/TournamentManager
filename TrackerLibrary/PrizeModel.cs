namespace TrackerLibrary
{
    public class PrizeModel
    {
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
    }
}