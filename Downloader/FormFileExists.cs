using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZEMMOURI_Downloader
{
    /// <summary>
    /// ToDoc : FormFileExists
    /// </summary>
    public partial class FormFileExists : Form
    {
        /// <summary>
        /// ToDoc : FileName
        /// </summary>
        string FileName;
        /// <summary>
        /// ToDoc : response
        /// </summary>
        public Response response;
        /// <summary>
        /// ToDoc : FormFileExists(string fileName)
        /// </summary>
        /// <param name="fileName"></param>
        public FormFileExists(string fileName)
        {
            FileName = fileName;
            InitializeComponent();
            LabelFileName.Text = FileName;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Process.Start(FileName);
        }

        private void buttonOverwrite_Click(object sender, EventArgs e)
        {
            response = Response.Overwrite;
            Close();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            response = Response.SaveAs;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            response = Response.Cancel;
            Close();
        }

        private void buttonAutoRename_Click(object sender, EventArgs e)
        {
            response = Response.AutoRename;
            Close();
        }
    }

    /// <summary>
    /// ToDoc : Response
    /// </summary>
    public enum Response
    {
        /// <summary>
        /// ToDoc : None
        /// </summary>
        None,
        /// <summary>
        /// ToDoc : Overwrite
        /// </summary>
        Overwrite,
        /// <summary>
        /// ToDoc : Auto Rename
        /// </summary>
        AutoRename,
        /// <summary>
        /// ToDoc : SaveAs
        /// </summary>
        SaveAs,
        /// <summary>
        /// ToDoc : Cancel
        /// </summary>
        Cancel
    }
}
