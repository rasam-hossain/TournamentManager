using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Shows a list of team members for a particular team
        /// </summary>
        public List<TeamMemberModel> TeamMembers { get; set; } = new List<TeamMemberModel>(); 

        /// <summary>
        /// Represents the name of the team
        /// </summary>
        public string TeamName { get; set; } 

    }
}
