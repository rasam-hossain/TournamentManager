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
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            prizes.Add(model);


            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
