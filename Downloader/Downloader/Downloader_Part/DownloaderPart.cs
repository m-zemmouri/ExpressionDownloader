using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZEMMOURI_Downloader.File_State.File_Part;
using System.Net;

namespace ZEMMOURI_Downloader.Downloader.Downloader_Part
{
    class DownloaderPart
    {
        #region Constructor

        /// <summary>
        /// Constructor of DownloaderPart
        /// </summary>
        public DownloaderPart()
        {
        }

        public DownloaderPart(string URL, string Path, FilePart filePart)
        {
            this.path = Path;
            this.request = CreatRequest(URL, filePart.CurrentPosition, filePart.EndPosition, null);
        }

        public DownloaderPart(string URL, string Path, FilePart filePart, ConnexionParameter Parametre)
        {
            this.path = Path;
            this.request = CreatRequest(URL, filePart.CurrentPosition, filePart.EndPosition, Parametre);

        }

        
        #endregion

        #region Variables

        /// <summary>
        /// The Web Request
        /// </summary>
        private HttpWebRequest request = null;

        /// <summary>
        ///  The Web Response
        /// </summary>
        private HttpWebResponse response = null;

        /// <summary>
        /// The Path of the File Part
        /// </summary>
        private string path;

        #endregion

        #region Proprieties


        /// <summary>
        ///  The Web Request
        /// </summary>
        public HttpWebRequest Request
        {
            get
            {
                return request;
            }
            set
            {
                request = value;
            }
        }

        /// <summary>
        /// The Web Response
        /// </summary>
        public HttpWebResponse Response
        {
            get
            {
                return response;
            }
            set
            {
                response = value;
            }
        }

        /// <summary>
        /// The Path of the File Part
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }


        #endregion

        #region Methodes

        private HttpWebRequest CreatRequest(string URL, int from, int to, ConnexionParameter Parametre)
        {
            HttpWebRequest result;
            result = (HttpWebRequest)HttpWebRequest.Create(URL);
            if (to != -1)
            {
                result.AddRange(from, to);
            }
            else
            {
                result.AddRange(from);
            }

            if (Parametre != null)
            {
                if (!string.IsNullOrEmpty(Parametre.User))
                {
                    result.Credentials = new NetworkCredential(Parametre.User, Parametre.PassWord);
                }
                else
                {
                    result.Credentials = CredentialCache.DefaultCredentials;
                }

                if (!string.IsNullOrEmpty(Parametre.Proxy))
                {
                    result.Proxy = new WebProxy(Parametre.Proxy);
                }
            }
            return result;
        }




        #endregion
    }
}