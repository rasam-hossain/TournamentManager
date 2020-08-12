using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        /// <summary>
        /// Saves a new person to the text file database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The person information, including the unique id</returns>
        public PersonModel Createperson(PersonModel model)
        {
            // Load the text file
            // Convert the text to List<PersonModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            //Find the max id
            int currentId = 1;
            if (people.Count > 0)
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            // Add the new record with the new Id
            people.Add(model);

            // Save to peopleFile
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        // TODO - Wireup CreatePrize for the text files
        /// <summary>
        /// Saves a new prize to the text file database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
                
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            prizes.Add(model);


            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            
            // Find the max ID
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            // Identify the id where the next team needs to be added    
            model.Id = currentId;
            // Add the model to the the list of teams
            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            var listOfPeople = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            return listOfPeople;
        }
    }
}
