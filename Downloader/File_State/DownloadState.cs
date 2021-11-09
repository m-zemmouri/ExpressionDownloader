namespace ZEMMOURI_Downloader.File_State
{


    /// <summary>
    /// Download State (ready, Downloading, Ok, Error, Stoped)
    /// </summary>
    public enum DownloadState
    {
        /// <summary>
        /// Ready
        /// </summary>
        Ready,

        /// <summary>
        /// Downloading
        /// </summary>
        Downloading,

        /// <summary>
        /// Stoped by user
        /// </summary>
        Stoped,

        /// <summary>
        /// Paused by user
        /// </summary>
        Paused,

        /// <summary>
        /// Finished with Error
        /// </summary>
        Error,

        /// <summary>
        /// Finished with Error and Aborted
        /// </summary>
        Aborted,

        /// <summary>
        /// Ok, Finished
        /// </summary>
        Ok
    }
}