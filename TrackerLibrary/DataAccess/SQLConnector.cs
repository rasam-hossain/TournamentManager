using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "TournamentManager";
        public PersonModel Createperson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                // All the parameters are added in order to pass in later on
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // The parameters will be passed in and the stored procedure will be executed
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                /* This will look into the dynamic parameter list p,  
                / and find @id parameter of type int */
                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        /// <summary>
        /// Saves a new prize to the SQL database
        /// </summary>
        /// <param name="model">The prize infromation</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
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

        /// <summary>
        /// Create the Team Model - passing the TeamName and retrieving Id as output
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                // All the parameters are added in order to pass in later on
                var q = new DynamicParameters();
                q.Add("@TeamName", model.TeamName);
                q.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // The parameters will be passed in and the stored procedure will be executed
                connection.Execute("dbo.spTeams_Insert", q, commandType: CommandType.StoredProcedure);

                /* This will look into the dynamic parameter list p,  
                / and find @id parameter of type int */
                model.Id = q.Get<int>("@id");

                foreach (PersonModel teamMember in model.TeamMembers)
                {
                    var t = new DynamicParameters();
                    t.Add("@TeamId", model.Id);
                    t.Add("@PersonId", teamMember.Id);
                    

                    connection.Execute("dbo.spTeamMembers_Insert", t, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        /// <summary>
        /// This method returns all the person 
        /// </summary>
        /// <returns></returns>
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }
    }
}
