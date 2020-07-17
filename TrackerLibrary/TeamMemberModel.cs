using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrackerLibrary
{
    public class TeamMemberModel
    {
        /// <summary>
        /// First Name of the Person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the Team Member
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Emails Address of the team member
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Contact Number/Cellphone of the team member
        /// </summary>
        public string ContactNumber { get; set; }
        
    }
}
