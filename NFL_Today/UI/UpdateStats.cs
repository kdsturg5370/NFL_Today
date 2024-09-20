using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using Microsoft.Scripting.Hosting;


namespace NFL_Today.UI
{
    public partial class UpdateStats : Form
    {
        public UpdateStats()
        {
            InitializeComponent();
        }


    //    //class Program
    //    //{
    //        public void Import(string[] args)
    //        {
    //            SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
    //            string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
    //            string LogFolder = @"C:\Log\";
    //            try
    //            {
    //                //Declare Variables and provide values
    //                string SourceFolderPath = @"C:\scraper_api\Source\"; //Provide the Source Folder where files are present
    //                string FileExtension = ".csv"; //Provide the extension of files you need to load, can be .txt or .csv
    //                string FileDelimiter = ","; // provide the file delimiter such as comma or pipe
    //                string ArchiveFolder = @"C:\scraper_api\Archive\"; //Provide the archive folder path where files will be moved
    //                string TableName = "Passing_Stats"; //Provide the table name in which you would like to load the files.

    //                //string query = "Select * FROM Passing_Stats";
    //                //SQLiteCommand cmd = new SQLiteCommand(query, conn);

    //                //DataTable dt = new DataTable();

    //                //SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

    //                //Create Connection to SQL Server in which you like to load files

    //                //conn.Open();
    //                //SqlConnection SQLConnection = new SqlConnection();
    //                //SQLConnection.ConnectionString = "Data Source = (local); Initial Catalog =TechBrothersIT; "
    //                //+ "Integrated Security=true;";

    //                //Reading file names one by one
    //                string[] fileEntries = Directory.GetFiles(SourceFolderPath, "*" + FileExtension);
    //                foreach (string fileName in fileEntries)
    //                {

    //                    //Writing Data of File Into Table
    //                    int counter = 0;
    //                    string line;
    //                    string ColumnList = "";

    //                    System.IO.StreamReader SourceFile = new System.IO.StreamReader(fileName);
    //                    conn.Open();
    //                    while ((line = SourceFile.ReadLine()) != null)
    //                    {
    //                        if (counter == 0)
    //                        {
    //                            //By using Header Row, Build Column List
    //                            ColumnList = "[" + line.Replace(FileDelimiter, "],[") + "]";

    //                        }
    //                        else
    //                        {

    //                            //Build and Execute Insert Statement to insert record
    //                            string query = "Insert into " + TableName + " (" + ColumnList + ") ";
    //                            query += "VALUES('" + line.Replace(FileDelimiter, "','") + "')";

    //                            SQLiteCommand SQLCmd = new SQLiteCommand(query, conn);
    //                            SQLCmd.ExecuteNonQuery();
    //                        }

    //                        counter++;
    //                    }

    //                    SourceFile.Close();
    //                    conn.Close();
    //                    //move the file to archive folder after adding datetime to it
    //                    File.Move(fileName, ArchiveFolder + "\\" +
    //                    (fileName.Replace(SourceFolderPath, "")).Replace(FileExtension, "")
    //                     + "_" + datetime + FileExtension);
    //                }
    //            }
    //            catch (Exception exception)
    //            {
    //                // Create Log File for Errors
    //                using (StreamWriter sw = File.CreateText(LogFolder
    //                    + "\\" + "ErrorLog_" + datetime + ".log"))
    //                {
    //                    sw.WriteLine(exception.ToString());

    //                }

    //            }


    //        }



    //}

    

   

    private void btnUpdPassStat_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
