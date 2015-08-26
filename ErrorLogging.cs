using System;
using System.IO;

namespace EdsACPlugin
{
    internal class ErrorLogging
    {
        internal static void LogError(string logFile, Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(logFile, true))
            {
                sw.WriteLine("============================================================================");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine("Error: " + ex.Message);
                sw.WriteLine("Source: " + ex.Source);
                sw.WriteLine("Stack: " + ex.StackTrace);
                if (ex.InnerException != null)
                {
                    sw.WriteLine("Inner: " + ex.InnerException.Message);
                    sw.WriteLine("Inner Stack: " + ex.InnerException.StackTrace);
                }
                sw.WriteLine("============================================================================");
                sw.WriteLine("");
                sw.Close();
            }
        }
    }
}