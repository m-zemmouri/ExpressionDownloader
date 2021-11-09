using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using XMLSerializationLibrary;
using XPTable;
using XPTable.Models;
using ZEMMOURI_Downloader.File_State;
using ZEMMOURI_Downloader.Downloader;
using ZEMMOURI_Downloader.File_SourceDestination;


namespace ZEMMOURI_Downloader
{
    public partial class ListDownloads : UserControl
    {
        #region Constructor

        /// <summary>
        /// ListDownloads Component
        /// </summary>
        /// <param name="listFileDownloadInfo">A List of FileSourceDestination</param>
        public ListDownloads(ListFileSourceDestination listFileDownloadInfo)
        {
            InitializeComponent();
            ListFiles = new ListFileState(listFileDownloadInfo);
            ListDownloaders = new ListDownloader(Program.DefaultMaxDownloads, ListFiles);
            AddRows();
        }

        #endregion

        #region Variables

        /// <summary>
        /// List of Files State.
        /// </summary>
        ListFileState ListFiles;

        /// <summary>
        /// List of Downloaders
        /// </summary>
        ListDownloader ListDownloaders;

        #endregion

        #region Methodes

        /// <summary>
        /// Add Row to the Table
        /// </summary>
        /// <param name="fileState">FileState</param>
        private void AddRow(FileState fileState)
        {
            if (fileState != null)
            {
                Cell ID_Cell = new Cell(fileState.ID.ToString());
                Cell StateImage_Cell = new Cell();
                Cell Name_Cell = new Cell(fileState.Name);
                Cell Source_Cell = new Cell(fileState.Source);
                Cell State_Cell = new Cell(fileState.State.ToString());
                Cell Size_Cell = new Cell(fileState.Size);
                Cell RecievedData_Cell = new Cell(fileState.RecievedData);
                Cell Progress_Cell = new Cell(fileState.Progress);
                Cell StartTime_Cell = new Cell(fileState.StartTime);
                Cell ElapsedTime_Cell = new Cell(fileState.ElapsedTime);
                Cell FishedTime_Cell = new Cell(fileState.FinishTime);
                Cell NBTries_Cell = new Cell(fileState.NbTries);

                Row row = new Row(new Cell[] { ID_Cell, StateImage_Cell, Name_Cell, Source_Cell, State_Cell, Size_Cell, RecievedData_Cell, Progress_Cell, StartTime_Cell, ElapsedTime_Cell, FishedTime_Cell, NBTries_Cell });

                tableDetail.TableModel.Rows.Add(row);
            }
        }

        /// <summary>
        /// Modify the content of a Row
        /// </summary>
        /// <param name="fileState">FileState</param>
        private void BindingRow(FileState fileState)
        {
            if (fileState != null)
            {
                try
                {
                    Row row = tableDetail.TableModel.Rows[ListFiles.Items.IndexOf(fileState)];

                    //Don't Changes : row.Cells[columnModel.Columns.IndexOf(ID_NumberColumn)].Data = fileState.ID;
                    row.Cells[columnModel.Columns.IndexOf(State_ImageColumn)].Data = this.imageList.Images[(int)fileState.State];
                    //Don't Changes : row.Cells[columnModel.Columns.IndexOf(Name_TextColumn)].Data = fileState.Name;
                    //Don't Changes : row.Cells[columnModel.Columns.IndexOf(Source_TextColumn)].Data = fileState.Source;
                    row.Cells[columnModel.Columns.IndexOf(State_TextColumn)].Data = fileState.State.ToString(); ;
                    row.Cells[columnModel.Columns.IndexOf(Size_NumberColumn)].Data = fileState.Size;
                    row.Cells[columnModel.Columns.IndexOf(RecievedData_NumberColumn)].Data = fileState.RecievedData;
                    row.Cells[columnModel.Columns.IndexOf(Progress_ProgressBarColumn)].Data = fileState.Progress;
                    row.Cells[columnModel.Columns.IndexOf(StartTime_TextColumn)].Data = fileState.StartTime;
                    row.Cells[columnModel.Columns.IndexOf(ElapsedTime_TextColumn)].Data = fileState.ElapsedTime;
                    row.Cells[columnModel.Columns.IndexOf(FinishTime_TextColumn)].Data = fileState.FinishTime;
                    row.Cells[columnModel.Columns.IndexOf(NbTries_NumberColumn)].Data = fileState.NbTries;
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Add Rows to the table
        /// </summary>
        private void AddRows()
        {
            for (int i = 0; i < ListFiles.Items.Count; i++)
            {
                AddRow(ListFiles[i]);
            }
        }

        /// <summary>
        /// Modify the content of the table
        /// </summary>
        private void BindingRows()
        {
            for (int i = 0; i < ListFiles.Items.Count; i++)
            {
                BindingRow(ListFiles[i]);
            }
        }

        #endregion

        #region Methodes Interface Controle

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            uint FileID;
            for (int i = 0; i < tableDetail.SelectedIndicies.Length; i++)
            {
                FileID = ListFiles[tableDetail.SelectedIndicies[i]].ID;
                ListDownloaders.StopFile(FileID);
            }
        }

        private void toolStripButtonStopAll_Click(object sender, EventArgs e)
        {
            ListDownloaders.StopAll();
        }

        private void toolStripButtonSerialize_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ListFileState.WriteToXML(ListFiles, saveFileDialog.FileName);
            }
        }


        private void toolStripButtonDeSerialize_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ListFiles = ListFileState.ReadFromXML(openFileDialog.FileName);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            ListDownloaders.Dispose();
            Parent.Dispose();
        }

        private void toolStripComboBoxNbThreads_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Decimal newValue;
                newValue = Convert.ToDecimal(toolStripComboBoxNbThreads.Text);
                ListDownloaders.MaxDownloads = newValue;
            }
            catch
            {
                toolStripComboBoxNbThreads.Text = ListDownloaders.MaxDownloads.ToString();
            }
        }
        #endregion

    }
}
