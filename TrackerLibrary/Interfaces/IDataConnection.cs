using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Interfaces
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
