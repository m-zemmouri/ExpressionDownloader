using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ZEMMOURI_Downloader
{
    static class Program
    {


        #region static Variables

        /// <summary>
        /// Letters
        /// </summary>
        public static string[] Letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        /// <summary>
        /// The Max Number of Simetaneouse downloads
        /// </summary>
        public static decimal DefaultMaxDownloads = 5;

        /// <summary>
        /// The Max Number of downloads tries
        /// </summary>
        public static decimal MaxTries = 5;

        /// <summary>
        /// Temporary Extension of the downloading files
        /// </summary>
        private static string TemporaryExtension = ".ZEM";

        /// <summary>
        /// Delete the temporaries files or not, in Case of failure
        /// </summary>
        public static bool DeleteTemporaryFiles = true;

        #endregion
        
        #region static Methodes

        public static string GetTemporaryName(string FileName)
        {
            return FileName + Program.TemporaryExtension;
        }

        public static string GetTemporaryName(string RootPath, string FileName)
        {
            string result;
            result = Program.GetTemporaryName(RootPath) + "\\" + Program.GetTemporaryName(FileName);
            return result;
        }
       
        
        public static string GetFileName(string TemporaryName)
        {
            return TemporaryName.Substring(0, TemporaryName.Length - Program.TemporaryExtension.Length);
        }
        
        public static string AutoRename(string FileName)
        {
            return FileName + "_";
        }
        
        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
