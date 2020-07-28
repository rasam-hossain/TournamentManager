using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection 
    {
        // TODO - Wireup CreatePrize for the text files
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
