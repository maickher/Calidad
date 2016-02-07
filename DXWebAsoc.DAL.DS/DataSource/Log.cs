using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DXWebAsoc.DAL.DS
{
    /// <summary>
    /// Class Log: To track all exceptions lauch by DataBase connection errors. 
    /// </summary>
    class Log
    {
        public static void WriteMessage(String pMethod, String pMessage)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy hh:MM:ss");
            String archive = "C:\\TEMP\\MIToolDatabaseLog" + DateTime.Now.ToString("dd/MM/yyyy") + ".txt";
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(archive, true);
                file.WriteLine("------------------------------------------");
                file.WriteLine("Method :" + pMethod);
                file.WriteLine("Date  :" + date);
                file.WriteLine("Detail");
                file.WriteLine("\n");
                file.WriteLine("Message " + pMessage);
                file.WriteLine("\n");
                file.WriteLine("------------------------------------------");
                file.WriteLine("\n");
                file.Close();
            }
            catch{}
        }

        public static void WriteException(String pMethod, Exception pException)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy hh:MM:ss");
            String archieve = "C:\\TEMP\\MIToolDatabaseLog" + DateTime.Now.ToString("dd/MM/yyyy") + ".txt";            
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(archieve, true);
                file.WriteLine("------------------------------------------");
                file.WriteLine("Method :" + pMethod);
                file.WriteLine("Date :" + date);
                file.WriteLine("Detail");
                file.WriteLine("\n");
                file.WriteLine("Message " + pException.Message);
                file.WriteLine("\n");
                file.WriteLine("StackTrace " + pException.StackTrace);
                file.WriteLine("\n");
                file.WriteLine("Source " + pException.Source);
                file.WriteLine("\n");
                file.WriteLine("ToString() " + pException.ToString());
                file.WriteLine("------------------------------------------");
                file.WriteLine("\n");
                file.Close();
            }
            catch { }
        }
    }
}
