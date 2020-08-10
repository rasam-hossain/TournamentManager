using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents an unique id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Represents the FirstName of the team member
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Represents the Last name of the team member
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Represents the email address of the team memeber
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Represents the cell phone number of the team member
        /// </summary>
        public string CellPhoneNumber { get; set; }
        
        /// <summary>
        /// Represents a read-only property full name
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        
        public PersonModel()
        {

        }
        public PersonModel(string firstName, string lastName, string emailAddress, string cellPhoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellPhoneNumber = cellPhoneNumber;
        }
    }
}
