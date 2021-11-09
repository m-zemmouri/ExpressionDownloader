using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using ZEMMOURI_Downloader.File_State;

namespace ZEMMOURI_Downloader.Downloader
{

    /// <summary>
    /// Describes a downloader by :    
    ///  - downloader     
    ///  - Downloader State    
    /// </summary>
    public class Downloader
    {
        #region Constructor

        /// <summary>
        /// Constructor of Downloader
        /// </summary>
        public Downloader(uint DownloaderID)
        {
            iD = DownloaderID;
            client = new WebClient();
            state = DownloaderState.Ready;
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompletedCallback);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
        }

        #endregion

        #region Variables


        /// <summary>
        /// Downloader ID
        /// </summary>
        private uint iD;

        /// <summary>
        /// The File's downloader
        /// </summary>
        private WebClient client;

        /// <summary>
        /// The downloader state
        /// </summary>
        private DownloaderState state;

        /// <summary>
        /// File ID
        /// </summary>
        private FileState fileState;

        #endregion

        #region Proprieties


        /// <summary>
        /// Downloader ID
        /// </summary>
        public uint ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }

        /// <summary>
        /// The downloader
        /// </summary>
        public WebClient Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }

        /// <summary>
        /// The downloader state
        /// </summary>
        public DownloaderState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        /// <summary>
        /// FileState
        /// </summary>
        public FileState FileState
        {
            get
            {
                return fileState;
            }
            set
            {
                fileState = value;
            }
        }

        #endregion

        #region Methodes

        /// <summary>
        /// Prepare the Download of a file
        /// </summary>
        /// <param name="fileState">a FileState to Download</param>
        public void Prepare(FileState fileState)
        {
            try
            {
                if (fileState != null )
                {
                    fileState.Prepare();

                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Start the Download of a file
        /// </summary>
        /// <param name="fileState">a FileState to Download</param>
        public void Download(FileState fileState)
        {
            try
            {
                if (fileState != null && fileState.Destination != null && fileState.Destination != "")
                {
                    fileState.Destination = Program.GetTemporaryName(fileState.Destination);
                    FileState = fileState;
                    State = DownloaderState.Busy;
                    //Client.DownloadFileAsync(new Uri(fileState.Source), fileState.Destination, fileState);
                    Client.DownloadFileAsync(new Uri(fileState.Source), fileState.Destination);
                    fileState.StartTime = DateTime.Now;
                    fileState.State = DownloadState.Downloading;
                    fileState.NbTries++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Complete the Download of a file
        /// </summary>
        /// <param name="fileState">a FileState Downloaded</param>
        public void Complete(FileState fileState)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        /// <summary>
        /// Pause the download
        /// </summary>
        public void Pause()
        {
            try
            {
                //TODO: implement
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Stop the download
        /// </summary>
        public void Stop()
        {
            try
            {
                Client.CancelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// the handler for ProgressChanged event.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event</param>
        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            FileState.Size = e.TotalBytesToReceive;
            FileState.RecievedData = e.BytesReceived;
            FileState.Progress = e.ProgressPercentage;
        }

        /// <summary>
        /// the handler for CompletedCallback event.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event</param>
        private void DownloadCompletedCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //FileState.FileState fileState = e.UserState as FileState.FileState;

            if (e.Cancelled) // Cancelled by user
            {
                FileState.State = DownloadState.Stoped;
                if (Program.DeleteTemporaryFiles)
                {
                    File.Delete(FileState.Destination);
                }
            }
            else if (e.Error != null) // Error
            {
                FileState.State = DownloadState.Error;
            }
            else // Ok
            {
                FileState.State = DownloadState.Ok;
                Directory.Move(FileState.Destination, Program.GetFileName(FileState.Destination));
            }
            State = DownloaderState.Ready;
            FileState = null;
            //ToDo: décloncher un evènement
        }

        #endregion
    }
}