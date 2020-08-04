using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new prize to the SQL database
        /// </summary>
        /// <param name="model">The prize infromation</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("TournamentManager")))
            {
                // All the parameters are added in order to pass in later on
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // The parameters will be passed in and the stored procedure will be executed
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                /* This will look into the dynamic parameter list p,  
                / and find @id parameter of type int */
                model.Id = p.Get<int>("@id");
                return model;
            }
        }
    }
}
