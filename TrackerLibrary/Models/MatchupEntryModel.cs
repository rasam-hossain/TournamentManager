namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Represents the score for the particular team
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Represents the parent matchup of the current team
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>
        /// <remarks>
        /// 
        /// </remarks>
        public MatchupEntryModel(double initialScore)
        {

        }
    }
}