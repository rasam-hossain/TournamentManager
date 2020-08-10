using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the Id of the Team
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Shows a list of team members for a particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); 

        

    }
}
