/*
 * ============================================================================
 * Project :
 * ---------
 * 
 *  Title : ZEMMOURI Encryptor Decryptor
 *  -------
 *  Description :
 *  -----------
 *  This project lets the user to Encrypte or Decrypte his folders and files with a Password
 * ============================================================================
 * ============================================================================
 * Class :
 * -------
 *  Name : FormAbout
 *  ------
 *  Description : 
 *  -------------
 *  The About Form of Application.
 * ============================================================================
 * ============================================================================
 * Author :
 * --------
 * ZEMMOURI Mohamed m.zemmouri@gmail.com
 * ============================================================================
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZEMMOURI_Downloader
{
    /// <summary>
    /// The About Form
    /// </summary>
    public partial class FormAbout : Form
    {
        /// <summary>
        /// the About Form
        /// </summary>
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelDescription.Top -= 10;
            if (labelDescription.Top <= -labelDescription.Height)
                labelDescription.Top = panelDescription.Height;
        }

    }
}