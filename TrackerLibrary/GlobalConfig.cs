using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            // We want to have either or both
            if(database)
            {
                // TODO - Set-up the SQL connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                //  TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
