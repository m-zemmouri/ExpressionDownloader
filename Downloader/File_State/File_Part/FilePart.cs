using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZEMMOURI_Downloader.File_State.File_Part
{
    /// <summary>
    /// A Part of File.
    /// </summary>
    public class FilePart
    {
        #region Constructor

        /// <summary>
        /// Constructor of FilePart
        /// </summary>
        public FilePart()
        {
        }

        /// <summary>
        /// Constructor of FilePart
        /// </summary>
        /// <param name="Range">The Range Part in the File</param>
        /// <param name="StartPosition">The position of the begging of the Part in the File</param>
        /// <param name="EndPosition">The position of the end of the Part in the File</param>
        public FilePart(uint Range, int StartPosition, int EndPosition)
        {
            this.range = Range;
            this.startPosition = StartPosition;
            this.currentPosition = StartPosition;
            this.endPosition = EndPosition;
        }

        #endregion

        #region Variables

        /// <summary>
        /// Range Part
        /// </summary>
        private uint range;

        /// <summary>
        /// The position of the begging of the Part in the File
        /// </summary>
        private int startPosition;


        /// <summary>
        /// current endPosition of download
        /// </summary>
        private int endPosition;

        /// <summary>
        /// current Position of download
        /// </summary>
        private int currentPosition;

        #endregion

        #region Proprieties

        /// <summary>
        /// File ID
        /// </summary>
        public uint Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }

        /// <summary>
        /// The position of the begging of the Part in the File
        /// </summary>
        public int StartPosition
        {
            get
            {
                return startPosition;
            }
            set
            {
                startPosition = value;
            }
        }

        /// <summary>
        /// current endPosition of download
        /// </summary>
        public int EndPosition
        {
            get
            {
                return endPosition;
            }
            set
            {
                endPosition = value;
            }
        }

        /// <summary>
        /// current Position of download
        /// </summary>
        public int CurrentPosition
        {
            get
            {
                return currentPosition;
            }
            set
            {
                currentPosition = value;
            }
        }

        /// <summary>
        /// The Part Download Progress
        /// </summary>
        public int Progress
        {
            get
            {
                int result = 0;
                try
                {
                    result = ((currentPosition - startPosition) * 100) / (endPosition - startPosition);
                }
                catch
                {
                }
                return result;
            }
        }

        #endregion        

        #region Methodes

        /// <summary>
        /// Adjust the Current Position of the part.
        /// </summary>
        public void AdjustCurrentPosition(string path)
        {
            currentPosition=startPosition;
            try
            {
                FileInfo part = new FileInfo(path);
                currentPosition +=(int) part.Length;
            }
            catch
            {
            }
        }

        #endregion
    }
}