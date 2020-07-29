using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the fee to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Shows a list of teams who entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }

        /// <summary>
        /// Shows a list of prizes set for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list of lists for the matchup teams
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
