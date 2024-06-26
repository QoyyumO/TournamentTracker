﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InnitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - Set up the text file connection properly
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
