using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using ZEMMOURI_Downloader.Variables;
using ZEMMOURI_Downloader.File_SourceDestination;


namespace ZEMMOURI_Downloader
{
    /// <summary>
    /// ToDoc : FormMain
    /// </summary>
    public partial class FormMain : Form
    {
        #region Variables

        ExpressionDownload expressionDownload;
        ListFileSourceDestination ListFiles;
        bool closeFromContextMenu = false;
        string DefaultDestination;
        int nbDownloads = 0;



        #endregion

        #region FormMain

        /// <summary>
        /// The Main Form
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            MyInitialization();
        }

        void MyInitialization()
        {
            // 
            // comboBoxVarType
            // 
            
            Type VarType = typeof(VariableType);

            foreach (string varType in Enum.GetNames(VarType))
            {
                comboBoxVarType.Items.Add(varType);
            }

            comboBoxVarType.SelectedItem = "Number";

            // 
            // comboBoxStepDuration
            //     

            Type DurationType = typeof(DurationType);

            foreach (string durationType in Enum.GetNames(DurationType))
            {
                comboBoxStepDuration.Items.Add(durationType);
            }
            
            comboBoxStepDuration.SelectedItem = "Day";

            // 
            // comboBoxFirstLetter
            //     
            comboBoxFirstLetter.Items.AddRange(Program.Letters);
            
            // 
            // comboBoxLastLetter
            //     
            comboBoxLastLetter.Items.AddRange(Program.Letters);

            // 
            // dateTimePickerFirst
            //     
            DateTime Now = DateTime.Now;
            dateTimePickerFirst.Value = new DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second);
            
            // 
            // dateTimePickerLast
            //     
            dateTimePickerLast.Value = new DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second);
            
            // 
            // Binding
            //  
            expressionDownload = new ExpressionDownload();
            ListFiles = new ListFileSourceDestination();
            //Binding();
        }


        void Binding()
        {
            expressionDownloadBindingSource.DataSource = expressionDownload;
            variableBindingSource.DataSource=expressionDownload.ListVariables;
            fileDownloadInfoBindingSource.DataSource = ListFiles;
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFromContextMenu = true;
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeFromContextMenu)
            {
                HideForm();
                e.Cancel = true;
            }
        }

        private void HideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideShowForm();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void HideShowForm()
        {
            if (ShowInTaskbar)
            {
                //Hide
                HideForm();
            }
            else
            {
                //Show
                ShowForm();
            }
        }

        private void HideForm()
        {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            HideShowToolStripMenuItem.Text = "Show";
        }

        private void ShowForm()
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            HideShowToolStripMenuItem.Text = "Hide";
        }


        #endregion

        #region ExpressionDownloads

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                expressionDownload.Destination = folderBrowserDialog.SelectedPath;
                textBoxDestination.Refresh();
            }
        }

        private void buttonDownloadExpression_Click(object sender, EventArgs e)
        {
            ListDownloads listDownloads = new ListDownloads(new ListFileSourceDestination(expressionDownload));
            NewDownloads(listDownloads);
      }


        #endregion

        #region ListDownloads

        private void dataGridViewListDownloads_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == destinationDataGridViewTextBoxColumn.Index)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewListFileDownloadInfos[destinationDataGridViewTextBoxColumn.Index, e.RowIndex].Value = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void dataGridViewListDownloads_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == destinationDataGridViewTextBoxColumn.Index)
            {
                if(dataGridViewListFileDownloadInfos[destinationDataGridViewTextBoxColumn.Index, e.RowIndex]!=null)
                    DefaultDestination = dataGridViewListFileDownloadInfos[destinationDataGridViewTextBoxColumn.Index, e.RowIndex].Value.ToString();
            }
            else if (dataGridViewListFileDownloadInfos[destinationDataGridViewTextBoxColumn.Index, e.RowIndex].Value == null)
            {
                dataGridViewListFileDownloadInfos[destinationDataGridViewTextBoxColumn.Index, e.RowIndex].Value = DefaultDestination;
            }
        }

        private void buttonDownloadList_Click(object sender, EventArgs e)
        {
            ListDownloads listDownloads = new ListDownloads((ListFileSourceDestination)fileDownloadInfoBindingSource.DataSource);
            NewDownloads(listDownloads);
        }
       
        #endregion

        private void toolStripButtonExpressionExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExpressionDownload.WriteToXML(expressionDownload, saveFileDialog.FileName);
            }
        }

        private void toolStripButtonExpressionImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                expressionDownload = ExpressionDownload.ReadFromXML(openFileDialog.FileName);
            }
        }

        private void buttonAddVar_Click(object sender, EventArgs e)
        {
            Variable var = null;
            VariableType VarType = (VariableType)comboBoxVarType.SelectedIndex;
            switch (VarType)
            {
                case VariableType.Number:
                    var = new Variable_Number(comboBoxSymbol.Text, (int)numericUpDownFirst.Value, (int)numericUpDownLast.Value, (int)numericUpDownStepNumber.Value, checkBoxAddZeros.Checked);
                    break;
                case VariableType.Letter:
                    var = new Variable_Letter(comboBoxSymbol.Text, comboBoxFirstLetter.Text[0], comboBoxLastLetter.Text[0], (int)numericUpDownStepLetter.Value);
                    break;
                case VariableType.Date:
                    var = new Variable_Date(comboBoxSymbol.Text, dateTimePickerFirst.Value, dateTimePickerLast.Value,(int)numericUpDownDateStep.Value, (DurationType)comboBoxStepDuration.SelectedIndex, comboBoxFormatDate.Text);
                    break;
                case VariableType.Collection:
                    List<string> Collection = new List<string>();

                    for (int i = 0; i < dataGridViewCollection.Rows.Count - 1; i++)
                        Collection.Add(dataGridViewCollection[0, i].Value.ToString());

                    var = new Variable_Collection(comboBoxSymbol.Text, Collection);
                    break;
            }
            variableBindingSource.Add(var);
        }

        private void buttonRemoveVar_Click(object sender, EventArgs e)
        {
            variableBindingSource.RemoveCurrent();            
        }

        private void comboBoxVarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlVarType.SelectedIndex = comboBoxVarType.SelectedIndex;
        }

       private void NewDownloads(ListDownloads listDownloads)
        {
            nbDownloads++;
            Cursor = Cursors.WaitCursor;
            TabPage tabPage = new TabPage();
            listDownloads.Dock = DockStyle.Fill;
            tabPage.Name = "Downloads_Page" + nbDownloads.ToString();
            tabPage.Text = "Downloads " + nbDownloads.ToString();
            tabPage.UseVisualStyleBackColor = true;
            tabPage.Controls.Add(listDownloads);
            this.tabControlDownloads.TabPages.Add(tabPage);

            Cursor = Cursors.Default;

        }

        private void comboBoxFormatDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerFirst.CustomFormat = comboBoxFormatDate.Text;
                dateTimePickerLast.CustomFormat = comboBoxFormatDate.Text;

            }
            catch
            {
                comboBoxFormatDate.SelectedIndex = 0;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //ToDo: Open Pages
        }

       private void toolStripButtonHideShowDetail_Click(object sender, EventArgs e)
        {
            tabControlMain.Visible = !tabControlMain.Visible;
            toolStripButtonHideShowDetail.Text = tabControlMain.Visible ? "Hide Detail" : "Show Detail";
        }

    }
}