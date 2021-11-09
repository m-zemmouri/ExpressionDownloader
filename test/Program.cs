using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace test
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            List<WebClient> l = new List<WebClient>();
            for (int i = 0; i < 10; i++)
            {
                l.Add(new WebClient());
            }
            l[1].Dispose();
            l[5].Dispose();
            l[1] = null;
            l[5] = null;
          
            MessageBox.Show(l.Count.ToString());
            for (int i = 0; i < 10; i++)
            {
                if (l[i] == null)
                    l[i] = new WebClient();
                else
                    l[i].Headers.Add("Content-Type","application/x-www-form-urlencoded");

            }
           
            for (int i = 0; i < 5; i++)
            {
                l.Add(new WebClient());
            }
            
MessageBox.Show(l.Count.ToString());
           
        }
    }
}
