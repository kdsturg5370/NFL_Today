using System.Data.SQLite;


namespace NFL_Today
{
    internal class database
    {
        public SQLiteConnection myConnection;

        public database()
        {
            myConnection = new SQLiteConnection("Data Source=C:\\Users\\kdstu\\source\\repos\\NFL_Today\\DB\\NFLDB.db");//for an existing db
                                                                                                                              //if (!File.Exists("./RecordArtist.sqlite3"))
                                                                                                                              //{


            //    SQLiteConnection.CreateFile("RecordArtist.sqlite3"); //to add to the program dependencies in the bin debug folder?
            //    System.Console.WriteLine("Database file created.");
            //}

        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
